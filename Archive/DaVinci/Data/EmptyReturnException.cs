using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaVinci.Data
{
	public class EmptyReturnException : Exception
	{
		public EmptyReturnException() : base("Return Complete: Return Was Successful")
		{

		}

		public EmptyReturnException(string message) : base(message)
		{
		}
	}
}
