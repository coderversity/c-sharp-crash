using System;
namespace c_sharp_crash
{
	public class CustomException : Exception
	{
		public CustomException()
		{
		}

		// Constructor overload that takes in a parameter and passes parameter value to
		// the base Exception class
		public CustomException(string message) : base(message)
		{

		}
	}
}

