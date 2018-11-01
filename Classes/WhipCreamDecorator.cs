using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes
{
	public class WhipCreamDecorator : DessertDecorator
	{
		public WhipCreamDecorator(IDessert dessert) : base(dessert)
		{
			_name = "Whip Cream";
			_price = 0.25;
		}
	}
}
