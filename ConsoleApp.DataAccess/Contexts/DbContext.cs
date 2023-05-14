using System;
using ConsoleApp.Core.Entities;

namespace ConsoleApp.DataAccess.Contexts
{
	public static class DbContext
	{
		public static List<Employee> Employees { get; set; } = new();

		public static List<Department> Departments { get; set; } = new();

		public static List<Company> Companies { get; set; } = new();
	}
}

