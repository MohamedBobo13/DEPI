using HospitalMangmentSystem.BLL.Dtos;
using HospitalMangmentSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.BLL.Manager
{
    public interface IPatientManager
    {
        IEnumerable<PatientReadDto> GetAll();
        PatientReadDto GetById(int id);
        void Add(PatientAddDto patientAddDto);
        void Update(PatientUpdateDto patientUpdateDto);
        void Delete(int id);
        void SaveChange();
    }
}
