using System;
using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Interfaces;
using ConsoleApp.DataAccess.Contexts;

namespace ConsoleApp.DataAccess.Implementations
{
    public class CompanyRepository : IRepository<Company>
    {
        public void Add(Company entity)
        {
            DbContext.Companies.Add(entity);
        }

        public void Delete(Company entity)
        {
            DbContext.Companies.Remove(entity);
        }

        public void Update(Company entity)
        {
            Company? company = DbContext.Companies.Find(comp => comp.CompanyId == entity.CompanyId);
            company.CompanyName = entity.CompanyName;
        }

        public Company? GetById(int id)
        {
            return DbContext.Companies.Find(comp => comp.CompanyId == id);
        }

        public Company? GetByName(string company)
        {
            return DbContext.Companies.Find(comp => comp.CompanyName == company);
        }

        public List<Company> GetAll()
        {
            return DbContext.Companies;
        }

        public List<Company> GetAllByName(string name)
        {
            return DbContext.Companies.FindAll(compn => compn.CompanyName == name);
        }
    }
}

