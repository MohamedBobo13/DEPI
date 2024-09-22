using HospitalMangmentSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.DAL.Repositories
{
    public interface IIssueRepo
    {
        IEnumerable<Issue> GetAll();
        Issue GetById(int id);
        void Delete(Issue issue);
        void Update(Issue issue);
        void Add(Issue issue);
        void SaveChange();
    }
}
