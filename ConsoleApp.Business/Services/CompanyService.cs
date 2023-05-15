using System;
using ConsoleApp.Business.Exceptions;
using ConsoleApp.Business.Interfaces;
using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Implementations;
using ConsoleApp.Business.Exceptions;
using ConsoleApp.Business.Helpers;

namespace ConsoleApp.Business.Services
{
    public class CompanyService : ICompanyService
    {
        public CompanyRepository _companyRepository { get; }

        public CompanyService()
        {
            _companyRepository = new CompanyRepository();
        }

        public void Create(string company, int id)
        {
            var exist = _companyRepository.GetByName(company);

            if (exist != null)
            {
                throw new AlreadyExistsException(Helper.Errors["AlreadyExistsException"]);
            }

            string name = company.Trim();

            if (name.Length <= 2)
            {
                throw new LengthException(Helper.Errors["LengthException"]);
            }

            Company companyType = new Company(name);
            _companyRepository.Add(companyType);
        }

        public void Delete(string company)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAll()
        {
            return _companyRepository.GetAll();
        }

        public Company GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

