using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC4_DoctorApp.Models
{
    public class Doctor
    {
        public Doctor()
        {
        }

        public Doctor(int doctorId, string name, string specailzation)
        {
            DoctorId = doctorId;
            Name = name;
            Specailzation = specailzation;
        }

        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specailzation { get; set; }
       
    }
}
