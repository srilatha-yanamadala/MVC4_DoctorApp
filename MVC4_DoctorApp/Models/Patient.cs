using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC4_DoctorApp.Models
{
    public class Patient
    {
        public Patient()
        {
        }

        public Patient(int patientId, string name)
        {
            PatientId = patientId;
            Name = name;
           
           
        }

        public int PatientId { get; set; }
        public string Name { get; set; }

       


    }
}
