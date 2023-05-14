using System;
using ConsoleApp.Core.Interfaces;

namespace ConsoleApp.Core.Entities
{
	public class Department : IEntity
	{
		private static int _id;
		public int DepartmentId { get; }

		public string DepartmentName { get; set; }
		public int EmployeeLimit { get; set; }
		public int CompanyId { get; set; }

		public Department()
		{
			DepartmentId = _id;
			_id++;
		}

		public Department(string name) : this()
		{
			DepartmentName = name;
		}

	}
}

