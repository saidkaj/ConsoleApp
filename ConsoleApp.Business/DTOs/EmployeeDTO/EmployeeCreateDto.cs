using System;
namespace ConsoleApp.Business.DTOs.EmployeeDTO
{
	public record EmployeeCreateDto(string name, string surname, string departmentName, int employeeId);

}

