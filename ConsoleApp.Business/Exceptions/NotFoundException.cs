using System;
namespace ConsoleApp.Business.Exceptions
{
	public class NotFoundException : Exception
	{
		public NotFoundException(string message) : base(message)
		{

		}
	}
}

