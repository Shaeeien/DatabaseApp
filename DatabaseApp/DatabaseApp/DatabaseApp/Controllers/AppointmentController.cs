using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using DatabaseApp.Models;
using System.Data.SqlClient;

namespace DatabaseApp.Controllers
{
    public class AppointmentController : Controller
    {
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\Appointments;Initial Catalog=Appointments;Integrated Security=True");

        private static int appointmentNumber = -1;
        public IActionResult Index()
        {
           return View();
        }

        [HttpPost]
        public IActionResult FromForm(string name, string surname, string phone)
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
            
            return View("FromForm");
        }

        public IActionResult FromForm()
        {
            string command = "SELECT * FROM Appointments";
            connection.Open();
            SqlCommand query = new SqlCommand(command, connection);
            SqlDataReader reader = query.ExecuteReader();
            List<Appointment> appointments = new List<Appointment>();
            while (reader.Read())
            {
                Appointment appointment = new Appointment()
                {
                    Number = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Surname = reader.GetString(2),
                    PhoneNumber = reader.GetString(3)                    
                };
                appointments.Add(appointment);
            }
            return View(appointments);
        }

        //Usuwa zawsze ostatnią dodaną(albo pierwszą)
        [HttpPost]
        public IActionResult DeleteAppointment(string ID)
        {
            string command = string.Format("DELETE FROM Appointments WHERE ID = {0}", ID);
            connection.Open();
            SqlCommand query = new SqlCommand(command, connection);
            int result = query.ExecuteNonQuery();
            string command1 = "SELECT * FROM Appointments";
            SqlCommand query1 = new SqlCommand(command1, connection);
            SqlDataReader reader = query.ExecuteReader();
            List<Appointment> appointments = new List<Appointment>();
            while (reader.Read())
            {
                Appointment appointment = new Appointment()
                {
                    Number = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Surname = reader.GetString(2),
                    PhoneNumber = reader.GetString(3)
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
