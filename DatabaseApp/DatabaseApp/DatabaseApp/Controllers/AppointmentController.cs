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
        /// <summary>
        /// DO SPRAWDZENIA! NADAL COŚ NIE DZIAŁA!
        /// </summary>
        /// <param name="id">Numer wizyty do edycji</param>
        /// <param name="doctor">Identyfikator doktora</param>
        /// <param name="appDate">Data wizyty</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult FindAppointmentToUpdate(int id)
        {
            using(var DbCtx = new AppointmentContext())
            {
                Appointment app = DbCtx.Appointments.Where(x => x.AppointmentId == id).Single();
                //DbCtx.Appointments.Remove(app);
                if(app != null)
                {                    
                    return View("UpdateAppointment", id);
                }                                    
            }
            return View("Error", "Błąd aktualizacji!");
        }

        public IActionResult UpdateAppointment(int id, int doctor, int patient, DateTime appDate, DateTime appHour)
        {
            using(var DbCtx = new AppointmentContext())
            {
                Appointment app = DbCtx.Appointments.Where(x => x.AppointmentId == id).Single();
                app.DoctorId = doctor;
                app.Time = new DateTime(appDate.Year, appDate.Month, appDate.Day, appHour.Hour, appHour.Minute, appHour.Second);
                //app.PatientId = 1;
                DbCtx.SaveChanges();
            }
            
            return View("AppointmentList");
        }

        //public IActionResult UpdateAppointment(int id)
        //{

        //}

        /// <summary>
        /// Wyszukiwanie wizyt po identyfikatorze
        /// </summary>
        /// <param name="id">Identyfikator wizyty</param>
        /// <returns></returns>
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
        public IActionResult RemoveAppointment(int id)
        {
            using(var DbCtx = new AppointmentContext())
            {
                Appointment toRemove = DbCtx.Appointments.Where(x => x.AppointmentId == id).FirstOrDefault();
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
