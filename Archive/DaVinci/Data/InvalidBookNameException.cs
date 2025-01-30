using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaVinci.Data
{
	public class InvalidBookNameException : Exception
	{
		public InvalidBookNameException() : base("Valid Book: Book Found")
		{

		}

		public InvalidBookNameException(string message) : base(message)
		{
		}
	}
}
