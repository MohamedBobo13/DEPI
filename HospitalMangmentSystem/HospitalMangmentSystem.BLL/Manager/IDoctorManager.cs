using HospitalMangmentSystem.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.BLL.Manger
{
    public interface IDoctorManager
    {
        IEnumerable<DoctorReadDto> GetAll();
        DoctorReadDto GetById(int id);
        void Add(DoctorAddDto doctorAddDto);
        void Update(DoctorUpdateDto doctorUpdateDto);
        void Delete(int id);
        void SaveChange();

    }
}
