using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes
{
	public class Milkshake : IDessert
	{
		public string GetDescription()
		{
			return "Ice cream and milk mixed to perfection";
		}

		public double GetCost()
		{
			return 1.99;
		}
	}
}
