using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC4_DoctorApp.Models;

namespace MVC4_DoctorApp.Models
{
   
   

        
        public class ApplicationDbContext : DbContext
        {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }

            public DbSet<Doctor> Doctors { get; set; }

            public DbSet<MVC4_DoctorApp.Models.Patient> Patient { get; set; }

            public DbSet<MVC4_DoctorApp.Models.Slot> Slot { get; set; }
       
    }
    
}
