using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using DatabaseApp.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DatabaseApp.Controllers
{
    public class AppointmentController : Controller
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);

        private static int appointmentNumber = -1;
        public IActionResult Index()
        {
           return View();
        }

        [HttpPost]
        public IActionResult AppointmentList(string name, string surname, string phone)
        {
            if(name != null && surname != null && phone != null)
            {
                connection.Open();
                string command = string.Format(
                    "INSERT INTO Appointments(ID, Name, Surname, Phone_number) VALUES({0}, '{1}', '{2}', '{3}')", appointmentNumber, name, surname, phone);
                SqlCommand query = new SqlCommand(command, connection);
                int result = query.ExecuteNonQuery();
                connection.Close();
                appointmentNumber++;
            }
            
            return View("AppointmentList");
        }

        public IActionResult AppointmentList()
        {
            string command = "select a.ID as AID, p.ID as PID, p.Name as PatientName, p.Surname as PatientSurname, d.ID as DID, d.Name as DoctorName, d.Surname as DoctorSurname, a.AppDate as AppointmentDate from Patient p, Doctor d, Appointments a where p.ID = a.Patient and d.ID = a.Doctor";
            connection.Open();
            SqlCommand query = new SqlCommand(command, connection);
            SqlDataReader reader = query.ExecuteReader();
            List<Appointment> appointments = new List<Appointment>();
            while (reader.Read())
            {
                Appointment app = new Appointment
                {
                    ID = reader.GetInt32(0),
                    AppointingPerson = new Patient
                    {
                        Name = reader.GetString(2),
                        Surname = reader.GetString(3),
                        ID = reader.GetInt32(1),
                        Doctor_data = new Doctor
                        {
                            ID = reader.GetInt32(4),
                            Name = reader.GetString(5),
                            Surname = reader.GetString(6)
                        }
                    },
                    Time = reader.GetDateTime(7)
                };
                appointments.Add(app);
            }
            connection.Close();
            return View(appointments);
        }

        [HttpPost]
        public IActionResult DeleteAppointment(string ID)
        {
            string command = string.Format("DELETE FROM Appointments WHERE ID = {0}", ID);
            connection.Open();
            SqlCommand query = new SqlCommand(command, connection);
            int result = query.ExecuteNonQuery();
            string command1 = "select p.Name as PatientName, p.Surname as PatientSurname, d.Name as DoctorName, d.Surname as DoctorSurname, a.AppDate as AppointmentDate from Patient p, Doctor d, Appointments a where p.ID = a.Patient and d.ID = a.Doctor";
            SqlCommand query1 = new SqlCommand(command1, connection);
            SqlDataReader reader = query.ExecuteReader();
            List<Appointment> appointments = new List<Appointment>();
            while (reader.Read())
            {
                Appointment appointment = new Appointment()
                {
                    //Number = reader.GetInt32(0),
                    //Name = reader.GetString(1),
                    //Surname = reader.GetString(2),
                    //PhoneNumber = reader.GetString(3)
                };
                appointments.Add(appointment);
            }
            return View("FromForm", appointments);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
