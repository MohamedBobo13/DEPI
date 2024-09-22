using HospitalMangmentSystem.BLL.Dtos;
using HospitalMangmentSystem.BLL.Manager;
using HospitalMangmentSystem.DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalMangmentSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly IIssueManager _issueManager;

        public IssuesController(IIssueManager issueManager)
        {
            _issueManager = issueManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_issueManager.GetAll());
        }
        [HttpGet]
        [Route("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_issueManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(IssueAddDto issueAddDto)
        {
            _issueManager.Add(issueAddDto);
            return NoContent();
        }
        [HttpPut]
        [Route("{Id}")]
        public ActionResult Update(int Id, IssueUpdateDto issueUpdateDto)
        {
            if (Id != issueUpdateDto.Id)
            {
                return BadRequest();
            }
            _issueManager.Update(issueUpdateDto);
            return NoContent();
        }
        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            _issueManager.Delete(Id);
            return NoContent();
        }
    }
}
