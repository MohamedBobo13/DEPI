using HospitalMangmentSystem.DAL.Data.DbHelper;
using HospitalMangmentSystem.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangmentSystem.DAL.Repositories
{
    public class IssueRepo : IIssueRepo
    {
        private readonly HospitalSystemContext _context;

        public IssueRepo(HospitalSystemContext context)
        {
            _context = context;
        }
        

        public IEnumerable<Issue> GetAll()
        {
            return _context.Issues.AsNoTracking().ToList();
        }

        public Issue GetById(int id)
        {
            return _context.Issues.Find(id);
        }
        public void Add(Issue issue)
        {
            _context.Add(issue);
        }
        public void Delete(Issue issue)
        {
            _context.Remove(issue);
        }
        
        public void Update(Issue issue)
        {
            
        }
        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
