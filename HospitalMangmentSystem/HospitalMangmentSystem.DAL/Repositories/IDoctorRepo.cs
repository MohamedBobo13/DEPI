using HospitalMangmentSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.DAL.Repositories
{
    public interface IDoctorRepo
    {
        IEnumerable<Doctor> GetAll();
        Doctor GetById(int id);
        void Delete(Doctor doctor);
        void Update(Doctor doctor);
        void Add(Doctor doctor);
        void SaveChange();
    }
}
