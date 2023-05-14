using System;
namespace ConsoleApp.Business.Helpers
{
	public static class Helper
	{
		public static Dictionary<string, string> Errors = new Dictionary<string, string>()
		{
			{"AlreadyExistsException", "This object already exists!"},
			{"SizeException", "Length is not enough!" }
		};
	}
}

