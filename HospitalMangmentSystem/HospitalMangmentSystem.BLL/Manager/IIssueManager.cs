using HospitalMangmentSystem.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.BLL.Manager
{
    public interface IIssueManager
    {
        IEnumerable<IssueReadDto> GetAll();
        IssueReadDto GetById(int id);
        void Add(IssueAddDto issueAddDto);
        void Update(IssueUpdateDto issueUpdateDto);
        void Delete(int id);
        void SaveChange();
    }
}
