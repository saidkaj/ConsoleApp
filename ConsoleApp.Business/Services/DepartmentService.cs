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
        public void Create(string departmentName, string company, int employeeLimit, int id)
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

            if (employeeLimit < 2)
            {
                throw new LengthException(Helper.Errors["LengthException"]);
            }

            Department department = new Department(departmentName, employeeLimit, companyt.CompanyId);
            _departmentRepository.Add(department);
        }

        public void Delete(string depatmentName)
        {
            var department = _departmentRepository.GetByName(depatmentName);

            if (department == null)
            {
                throw new NotFoundException($"Department {depatmentName} not found.");
            }

            _departmentRepository.Delete(department);
        }

        public void Update(int departmentId, int employeeLimit)
        {
            var department = _departmentRepository.GetById(departmentId);

            if (department == null)
            {
                throw new NotFoundException($"Department with ID - {departmentId} not found.");
            }

            if (employeeLimit < 2)
            {
                throw new LengthException(Helper.Errors["LengthException"]);
            }

            department.EmployeeLimit = employeeLimit;

            _departmentRepository.Update(department);
        }

        public List<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public Department GetById(int id)
        {
            var department = _departmentRepository.GetById(id);

            if (department == null)
            {
                throw new NotFoundException($"Department with ID - {id} not found.");
            }

            return department;
        }

        public Department GetByName(string departmentName)
        {
            var department = _departmentRepository.GetByName(departmentName);

            if (department == null)
            {
                throw new NotFoundException($"Department with name - {departmentName} not found.");
            }

            return department;
        }
    }
}

