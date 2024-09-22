using HospitalMangmentSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.DAL.Repositories
{
    public interface IPatientRepo
    {
        IEnumerable<Patient> GetAll();
        Patient GetById(int id);
        void Delete(Patient patient);
        void Update(Patient patient);
        void Add(Patient patient);
        void SaveChange();
    }
}
