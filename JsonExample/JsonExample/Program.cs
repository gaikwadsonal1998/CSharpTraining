﻿using ConsoleApp1_Serialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JsonExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Product p = new Product();
			p.jsonserializer();
		}
	}
}
