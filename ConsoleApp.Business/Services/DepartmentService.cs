using System;
using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Implementations;
using ConsoleApp.Business.Exceptions;
using ConsoleApp.Business.Helpers;

namespace ConsoleApp.Business.Services
{
    public class DepartmentService : IDepartmentService
    {
        public DepartmentRepository _departmentRepository { get; }

        public CompanyRepository _companyRepository { get; }

        public DepartmentService()
        {
            _departmentRepository = new DepartmentRepository();
            _companyRepository = new CompanyRepository();
        }
        public void Create(string departmentName, string company, int departmentLimit)
        {
            var name = departmentName.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new LengthException(Helper.Errors["LengthException"]);
            }

            if (_departmentRepository.GetByName(name) != null)
            {
                throw new AlreadyExistsException(Helper.Errors["AlreadyExistsException"]);
            }

            var companyt = _companyRepository.GetByName(company);
            if (companyt == null)
            {
                throw new NotFoundException($"{company} - doesn't exist");
            }

            if (departmentLimit >= 2)
            {
                throw new LengthException(Helper.Errors["LengthException"]);
            }

            Department department = new Department(departmentName, departmentLimit, companyt.CompanyId);
            _departmentRepository.Add(department);
        }

        public void Delete(string depatmentName)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Department GetByName(string departmentName)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, int departmentLimit)
        {
            throw new NotImplementedException();
        }
    }
}

