using System;
using ConsoleApp.Core.Entities;
namespace ConsoleApp.Business.Services
{
	public interface IDepartmentService
	{
		void Create(string departmentName, string company, int departmentLimit, int id);

		void Delete(string depatmentName);

		void Update(int id, int departmentLimit);

		Department GetByName(string departmentName);

		Department GetById(int id);

		List<Department> GetAll();
	}
}

