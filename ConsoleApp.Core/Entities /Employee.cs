using System;
using ConsoleApp.Core.Interfaces;

namespace ConsoleApp.Core.Entities
{
	public class Employee : IEntity
	{
		private static int _id;

		public int EmployeeId { get; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public double Salary { get; set; }

		public int CompanyId { get; set; }

		public int DepartmentId { get; set; }

		public Employee()
		{
			EmployeeId = _id;
			_id++;
		}

		public Employee(string name, string surname, int departmentId) : this()
		{
			Name = name;
			Surname = surname;
			DepartmentId = departmentId;
		}

	}
}

