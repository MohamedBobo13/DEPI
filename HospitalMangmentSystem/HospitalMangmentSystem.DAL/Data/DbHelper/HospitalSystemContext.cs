using HospitalMangmentSystem.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.DAL.Data.DbHelper
{
    public class HospitalSystemContext : DbContext
    {
        public HospitalSystemContext(DbContextOptions<HospitalSystemContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Issue> Issues { get; set; }

    }
}
