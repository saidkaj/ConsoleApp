using System;
namespace ConsoleApp.Business.Helpers
{
	public static class Helper
	{
		public static Dictionary<string, string> Errors = new Dictionary<string, string>()
		{
			{"AlreadyExistsException", "This object already exists!"},
			{"SizeException", "Length is not enough!" },
			{"NotValidWordException", "Entered word is not valid!" },
			{"CapacityNotEnoughException", "Department is already full!" }
		};
	}
}

