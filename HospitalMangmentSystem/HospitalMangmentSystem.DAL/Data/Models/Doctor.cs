﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.DAL.Data.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public int? PreformanceRate { get; set; }
        public ICollection<Patient> Patients { get; set; } = new HashSet<Patient>();


    }
}
