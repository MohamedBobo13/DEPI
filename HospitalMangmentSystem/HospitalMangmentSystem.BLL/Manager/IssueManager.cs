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
    public class IssueManager : IIssueManager
    {
        private readonly IIssueRepo _issueRepo;

        public IssueManager(IIssueRepo issueRepo)
        {
            _issueRepo = issueRepo;
        }
        
        public IEnumerable<IssueReadDto> GetAll()
        {
            var IssueModelList = _issueRepo.GetAll();
            var IssueDtoList = IssueModelList.Select(x => new IssueReadDto
            {
                Name = x.Name,
            });
            return IssueDtoList;
        }

        public IssueReadDto GetById(int id)
        {
            var IssueModel = _issueRepo.GetById(id);
            var IssueDto =  new IssueReadDto
            {
                Name = IssueModel.Name,
            };
            return IssueDto;
        }
        public void Add(IssueAddDto issueAddDto)
        {
            var IssueModel = new Issue()
            {
                Name = issueAddDto.Name,
            };
            _issueRepo.Add(IssueModel);
            _issueRepo.SaveChange();
        }
        public void Update(IssueUpdateDto issueUpdateDto)
        {
            var IssueModel = _issueRepo.GetById(issueUpdateDto.Id);
            IssueModel.Name = issueUpdateDto.Name;
            IssueModel.Id = issueUpdateDto.Id;
            _issueRepo.Update(IssueModel);
            _issueRepo.SaveChange();
        }
        public void Delete(int id)
        {
            var IssueModel = _issueRepo.GetById(id);
            _issueRepo.Delete(IssueModel);
            _issueRepo.SaveChange();
        }
       
        public void SaveChange()
        {
            _issueRepo.SaveChange();
        }
    }
}
