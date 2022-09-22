using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using DatabaseApp.Models;
using Microsoft.AspNetCore.Http;

namespace DatabaseApp.Controllers
{
    public class AppointmentController : Controller
    {
        public static AppointmentList appointmentList = new AppointmentList();
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
                Appointment appointment = new Appointment();
                appointment.Name = name;
                appointment.Surname = surname;
                appointment.PhoneNumber = phone;
                appointmentNumber++;
                appointment.Number = appointmentNumber;
                if (!appointmentList.IsAlreadyInTheList(appointment))
                    appointmentList.Add(appointment);
            }            
            return View(appointmentList);
        }

        public IActionResult FromForm()
        {
            return View(appointmentList);
        }

        //O CHUJ TU CHODZI
        [HttpPost]
        public IActionResult DeleteAppointment(string ID)
        {
            Appointment appointment = appointmentList.appointments.SingleOrDefault(x => x.Number == int.Parse(ID));
            appointmentList.appointments.Remove(appointment);
            return View(appointmentList);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
