using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaVinci.Data
{
	public class InvalidLoginException : Exception
	{
		public InvalidLoginException() : base("Valid Login: Login Successful")
		{

		}

		public InvalidLoginException(string message) : base(message)
		{
		}
	}
}
