using HospitalMangmentSystem.DAL.Data.DbHelper;
using HospitalMangmentSystem.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.DAL.Repositories
{
    public class DoctorRepo : IDoctorRepo
    {
        private readonly HospitalSystemContext _context;

        public DoctorRepo(HospitalSystemContext context)
        {
            _context = context;
        }
        public IEnumerable<Doctor> GetAll()
        {
            return _context.Doctors.AsNoTracking().ToList();
        }

        public Doctor GetById(int id)
        {
            return _context.Doctors.Find(id);
        }
        public void Add(Doctor doctor)
        {
           _context.Add(doctor);
        }

        public void Delete(Doctor doctor)
        {
            _context.Remove(doctor);
        }


        public void Update(Doctor doctor)
        {
            
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
