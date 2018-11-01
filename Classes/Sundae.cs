using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes
{
	public class Sundae : IDessert
	{
		public string GetDescription()
		{
			return "2 scoops of ice cream, with nuts and syrup.";
		}

		public double GetCost()
		{
			return 2.49;
		}
	}
}
