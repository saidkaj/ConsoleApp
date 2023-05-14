using System;
using ConsoleApp.Core.Entities;
namespace ConsoleApp.Business.Interfaces
{
	public interface ICompanyService
	{
		void Create(string company);
		void Delete(string company);

		Company GetById(int id);

		List<Company> GetAll();

	}
}

