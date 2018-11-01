using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes
{
	public class CherryDecorator : DessertDecorator
	{
		public CherryDecorator(IDessert dessert) : base(dessert)
		{
			_name = "Cherry";
			_price = 0.05;
		}
	}
}
