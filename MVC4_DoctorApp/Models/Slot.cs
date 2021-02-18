using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC4_DoctorApp.Models;

namespace MVC4_DoctorApp.Models
{
    public class Slot
    {
        public Slot()
        {
        }

        public Slot(int slotId, DateTime slotTime, Doctor doctorId, string bookingdetails, Patient patientId)
        {
            SlotId = slotId;
            SlotTime = slotTime;
            DoctorId = doctorId;
            Bookingdetails = bookingdetails;
            PatientId = patientId;

            
           
        }

        public int SlotId { get; set; }
        public DateTime SlotTime { get; set; }
        public Doctor DoctorId { get; set; }
        public Patient  PatientId { get; set; }
        public string Bookingdetails { get; set; }


    }
}
