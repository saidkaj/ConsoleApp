using System;
using ConsoleApp.Business.DTOs.EmployeeDTO;
using ConsoleApp.Core.Entities;

namespace ConsoleApp.Business.Interfaces
{
	public interface IEmployeeService
	{
		void Create(EmployeeCreateDto employeeCreateDto);
		void Delete(int id);
		void Update(int id, EmployeeCreateDto employeeCreateDto);

		List<Employee> GetAll(int skip, int take );

		List<Employee> GetEmployeeByDepartmentId(int id);

		List<Employee> GetEmployeeByName(string name);

		Employee GetEmployeeById(int id);

	}
}

