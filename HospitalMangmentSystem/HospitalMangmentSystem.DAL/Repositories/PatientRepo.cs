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
    public class PatientRepo : IPatientRepo
    {
        private readonly HospitalSystemContext _context;

        public PatientRepo(HospitalSystemContext context)
        {
            _context = context;
        }

        public IEnumerable<Patient> GetAll()
        {
            return _context.Patients.AsNoTracking().ToList();
        }

        public Patient GetById(int id)
        {
            return _context.Patients.Find(id);
        }
        public void Add(Patient patient)
        {
            _context.Add(patient);
        }
        public void Delete(Patient patient)
        {
            _context.Remove(patient);
        }
        public void Update(Patient patient)
        {
            
        }
        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
