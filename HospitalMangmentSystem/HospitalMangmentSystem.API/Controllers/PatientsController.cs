using HospitalMangmentSystem.BLL.Dtos;
using HospitalMangmentSystem.BLL.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalMangmentSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientManager _patientManager;

        public PatientsController(IPatientManager patientManager)
        {
            _patientManager = patientManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_patientManager.GetAll());
        }
        [HttpGet]
        [Route("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_patientManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(PatientAddDto patientAddDto)
        {
            _patientManager.Add(patientAddDto);
            return NoContent();
        }
        [HttpPut]
        [Route("{Id}")]
        public ActionResult Update(int Id, PatientUpdateDto patientUpdateDto)
        {
            if (Id != patientUpdateDto.Id)
            {
                return BadRequest();
            }
            _patientManager.Update(patientUpdateDto);
            return NoContent();
        }
        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            _patientManager.Delete(Id);
            return NoContent();
        }
    }
}