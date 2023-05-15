using System;
using ConsoleApp.Business.DTOs.EmployeeDTO;
using ConsoleApp.Business.Exceptions;
using ConsoleApp.Business.Helpers;
using ConsoleApp.Business.Interfaces;
using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Implementations;

namespace ConsoleApp.Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeRepository _employeeRepository { get; }

        public DepartmentRepository _departmentRepository { get; }

        public EmployeeService()
        {
            _employeeRepository = new();
            _departmentRepository = new();
        }


        public void Create(EmployeeCreateDto employeeCreateDto, int id)
        {
            var name = employeeCreateDto.name.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }

            if (!name.IsOnlyLetters())
            {
                throw new NotValidWordException(Helper.Errors["NotValidWordException"]);
            }

            var surname = employeeCreateDto.surname.Trim();
            if (string.IsNullOrWhiteSpace(surname))
            {
                if (!surname.IsOnlyLetters())
                {
                    throw new NotValidWordException(Helper.Errors["NotValidWordException"]);
                }
            }

            var department = _departmentRepository.GetByName(employeeCreateDto.departmentName.Trim());
            if (department == null)
            {
                throw new NotFoundException($"{employeeCreateDto.departmentName} - doesn't exist");
            }

            var count = _employeeRepository.GetEmployeeByDepartmentId(department.DepartmentId).Count;
            if (count >= department.EmployeeLimit)
            {
                throw new CapacityNotEnoughException(Helper.Errors["CapacityNotEnoughException"]);
            }

            Employee employee = new Employee(name, surname, department.DepartmentId);
            _employeeRepository.Add(employee);
        }

        public void Delete(int id)
        {
            var employee = _employeeRepository.GetById(id);

            if (employee == null)
            {
                throw new NotFoundException($"Employee with ID - {id} not found.");
            }

            _employeeRepository.Delete(employee);
        }

        public void Update(int id, EmployeeCreateDto employeeCreateDto)
        {
            var employee = _employeeRepository.GetById(id);

            if (employee == null)
            {
                throw new NotFoundException($"Employee with ID - {id} not found.");
            }
        }

        public List<Employee> GetAll(int skip, int take)
        {
            return _employeeRepository.GetAll();
        }

        public List<Employee> GetEmployeeByDepartmentId(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetById(id);

            if (employee == null)
            {
                throw new NotFoundException($"Employee with ID - {id} not found.");
            }

            return employee;
        }

        public List<Employee> GetEmployeeByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}

