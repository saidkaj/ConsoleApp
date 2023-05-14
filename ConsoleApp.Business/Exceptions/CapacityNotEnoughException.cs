using System;
namespace ConsoleApp.Business.Exceptions
{
	public class CapacityNotEnoughException : Exception
	{
		public CapacityNotEnoughException(string message) : base(message)
		{
		}
	}
}

