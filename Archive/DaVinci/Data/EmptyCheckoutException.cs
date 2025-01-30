using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaVinci_Mehtab.Data
{
	public class EmptyCheckoutException : Exception
	{
		public EmptyCheckoutException() : base("Checkout Complete: Successfully Checked Out")
		{

		}

		public EmptyCheckoutException(string message) : base(message)
		{
		}
	}
}
