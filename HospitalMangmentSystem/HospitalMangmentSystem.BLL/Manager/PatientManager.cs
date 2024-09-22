using HospitalMangmentSystem.BLL.Dtos;
using HospitalMangmentSystem.DAL.Data.Models;
using HospitalMangmentSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.BLL.Manager
{
    public class PatientManager : IPatientManager
    {
        private readonly IPatientRepo _patientRepo;

        public PatientManager(IPatientRepo patientRepo)
        {
            _patientRepo = patientRepo;
        }

        public IEnumerable<PatientReadDto> GetAll()
        {
            var PatientModelList = _patientRepo.GetAll();
            var PatientDtoList = PatientModelList.Select(x=> new PatientReadDto
            {
                Name = x.Name,
                Age = x.Age
            });
            return PatientDtoList;
        }

        public PatientReadDto GetById(int id)
        {
            var PatientModel = _patientRepo.GetById(id);
            var PatientDto =  new PatientReadDto
            {
                Name = PatientModel.Name,
                Age = PatientModel.Age
            };
            return PatientDto;
        }
        public void Add(PatientAddDto patientAddDto)
        {
            var PatientModel = new Patient
            {
                Name = patientAddDto.Name,
                Age = patientAddDto.Age,
                DoctorId = patientAddDto.DoctorId
            };
            _patientRepo.Add(PatientModel);
            _patientRepo.SaveChange();
        }

        public void Delete(int id)
        {
            var PatientModel = _patientRepo.GetById(id);
            _patientRepo.Delete(PatientModel);
            _patientRepo.SaveChange();
        }

        public void Update(PatientUpdateDto patientUpdateDto)
        {
            var PatientModel = _patientRepo.GetById(patientUpdateDto.Id);
            PatientModel.Id = patientUpdateDto.Id;
            PatientModel.Name = patientUpdateDto.Name;
            PatientModel.Age = patientUpdateDto.Age;
            PatientModel.DoctorId = patientUpdateDto.DoctorId;
            _patientRepo.Update(PatientModel);
            _patientRepo.SaveChange();
        }
        public void SaveChange()
        {
            _patientRepo.SaveChange();
        }

    }
}
