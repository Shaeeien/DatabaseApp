using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using DatabaseApp.Entities;
using System.Data.SqlClient;
using System.Configuration;
using DatabaseApp.Models;
using System;

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
        public IActionResult AppointmentList(int id)
        {             
            using(var DbCtx = new AppointmentContext())
            {
                Appointment app = new Appointment
                {
                    //AppointmentId = appointmentNumber,
                    //Doctor = DbCtx.Doctors.Find(doctorId),
                    //DoctorId = doctorId,
                    //Patient = DbCtx.Patients.Find(patientId),
                    //PatientId = patientId,
                    //Time = appTime
                };
                DbCtx.Appointments.Add(app);
                DbCtx.SaveChanges();
                appointmentNumber++;
            };

            return View();
        }

        public IActionResult AppointmentList()
        {
                        
            return View();
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
