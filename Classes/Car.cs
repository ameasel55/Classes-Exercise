using System;
using System.Collections.Generic;
namespace Classes
{
	public class Car
	{
	
		public Car() //default constructor
		{
			
		}

		public Car(string make, string model, int year) // custom constructor
		{
			Make = make;
			Model = model;
			Year = year;
		}



		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
	}
}

