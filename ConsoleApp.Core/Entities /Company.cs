using System;
using ConsoleApp.Core.Interfaces;

namespace ConsoleApp.Core.Entities
{
	public class Company : IEntity
	{
		private static int _id;

		public int CompanyId { get;}

		public string CompanyName { get; set; }

		public Company()
		{
			CompanyId = _id;
			_id++;
		}

		public Company(string name) : this()
		{
			CompanyName = name;
		}
	}


}

