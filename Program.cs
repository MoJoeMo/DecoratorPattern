using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Classes;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Milkshake shake = new Milkshake();
			Console.WriteLine(shake.GetDescription());
			IDessert dessert = new CherryDecorator(new WhipCreamDecorator(new Sundae()));
			Console.WriteLine(dessert.GetDescription());

			Console.ReadLine();
		}
	}
}
