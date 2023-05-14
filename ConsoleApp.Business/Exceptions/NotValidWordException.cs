using System;
namespace ConsoleApp.Business.Exceptions
{
	public class NotValidWordException : Exception
	{
		public NotValidWordException(string message) : base(message)
		{

		}
	}
}

