using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using DatabaseApp.Entities;
using System.Data.SqlClient;
using System.Configuration;
using DatabaseApp.Models;
using System;
using Microsoft.AspNetCore.Http;

namespace DatabaseApp.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }
        

        public IActionResult AppointmentSearch(int id)
        {             
            using(var DbCtx = new AppointmentContext())
            {
                Appointment app = DbCtx.Appointments.Where(x => x.AppointmentId == id).FirstOrDefault();
                if(app != null)
                {
                    return View("AppointmentSingle", id);
                }
                
            };
            return View("Error", "Nie ma takiej wizyty!");
            
        }

        public IActionResult AppointmentList()
        {
                        
            return View();
        }

        [HttpPost]
        public IActionResult DeleteAppointment(int ID)
        {
            using(var DbCtx = new AppointmentContext())
            {
                Appointment toRemove = DbCtx.Appointments.Where(x => x.AppointmentId == ID).FirstOrDefault();
                if(toRemove != null)
                {
                    DbCtx.Appointments.Remove(toRemove);
                    DbCtx.SaveChanges();
                }
                else
                {
                    return View("Error", "Błąd usuwania");
                }
                    
            }
            return View("AppointmentList");
        }

        public IActionResult AddAppointment(string doctor, DateTime appDate, DateTime appTime)
        {
            int id = int.Parse(doctor[0].ToString());
            Appointment app = new Appointment
            {
                PatientId = 1,
                DoctorId = id,
                Time = new DateTime(appDate.Year, appDate.Month, appDate.Day, appTime.Hour, appTime.Minute, appTime.Second)
            };
            using(var DbCtx = new AppointmentContext())
            {
                bool exists = (from appointment in DbCtx.Appointments
                               where appointment.DoctorId == app.DoctorId && appointment.PatientId == app.PatientId && appointment.Time == app.Time
                               select appointment).Any();
                if (exists)
                {
                    return View("Error", "Taka wizyta jest już umówiona!");
                }
                DbCtx.Appointments.Add(app);
                DbCtx.SaveChanges();
                return View("AppointmentList");                
            }
        }

        public IActionResult RegisterAppointment()
        {
            return View("AddAppointment");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
