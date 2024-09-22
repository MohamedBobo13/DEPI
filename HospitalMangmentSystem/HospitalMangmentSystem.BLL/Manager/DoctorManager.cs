using HospitalMangmentSystem.BLL.Dtos;
using HospitalMangmentSystem.DAL.Data.Models;
using HospitalMangmentSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.BLL.Manger
{
    public class DoctorManager : IDoctorManager
    {
        private readonly IDoctorRepo _doctorRepo;

        public DoctorManager(IDoctorRepo doctorRepo)
        {
            _doctorRepo = doctorRepo;
        }
        public IEnumerable<DoctorReadDto> GetAll()
        {
            var DoctorModelList =_doctorRepo.GetAll();
            var DoctorDtoList = DoctorModelList.Select(x => new DoctorReadDto()
            {
                Age = x.Age,
                Name = x.Name,
                PreformanceRate = x.PreformanceRate??0

            });
            return DoctorDtoList;
        }

        public DoctorReadDto GetById(int id)
        {
            var DoctorModel = _doctorRepo.GetById(id);
            var DoctorDto = new DoctorReadDto()
            {
                Age=DoctorModel.Age,
                Name = DoctorModel.Name,
                PreformanceRate=DoctorModel.PreformanceRate??0
            };
            return DoctorDto;
        }
        public void Add(DoctorAddDto doctorAddDto)
        {
            var DoctorModel = new Doctor
            {
                Name = doctorAddDto.Name,
                Age = doctorAddDto.Age,
                Salary = doctorAddDto.Salary
            };
            _doctorRepo.Add(DoctorModel);
            _doctorRepo.SaveChange();
        }

        public void Delete(int id)
        {
            var DoctorModel = _doctorRepo.GetById(id);
            _doctorRepo.Delete(DoctorModel);
            _doctorRepo.SaveChange();
        }

        public void Update(DoctorUpdateDto doctorUpdateDto)
        {
            var DoctorModel = _doctorRepo.GetById(doctorUpdateDto.Id);
            DoctorModel.PreformanceRate = doctorUpdateDto.PreformanceRate;
            DoctorModel.Salary = doctorUpdateDto.Salary;
            DoctorModel.Age = doctorUpdateDto.Age;
            DoctorModel.Name = doctorUpdateDto.Name;
            _doctorRepo.Update(DoctorModel);
            _doctorRepo.SaveChange();
        }
        public void SaveChange()
        {
            _doctorRepo.SaveChange();
        }
    }
}
