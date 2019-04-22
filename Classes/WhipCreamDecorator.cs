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
