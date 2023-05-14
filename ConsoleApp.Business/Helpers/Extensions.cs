using System;
using System.Text.RegularExpressions;

namespace ConsoleApp.Business.Helpers
{
	public static class Extensions
	{
        public static bool IsOnlyLetters(this string value)
		{
			return Regex.IsMatch(value, @"^[a-zA-z]+$");
		}
	}
}

