using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes
{
	public abstract class DessertDecorator : IDessert
	{
		private IDessert _dessert;

		protected string _name = "undefined";
		protected double _price = 0.0;

		public DessertDecorator(IDessert dessert)
		{
			_dessert = dessert;
		}

		public string GetDescription()
		{
			return string.Format("{0}, {1}", _dessert.GetDescription(), _name);
		}

		public double GetCost()
		{
			return _dessert.GetCost() + _price;
		}
	}
}
