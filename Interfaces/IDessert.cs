﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Interfaces
{
	public interface IDessert
	{
		string GetDescription();
		double GetCost();
	}
}
