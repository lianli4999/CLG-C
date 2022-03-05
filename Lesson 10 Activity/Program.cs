using System;
using System.Collections.Generic;
using RideShare.Models;



namespace RideShare
{
    class Program
    {
        static void Main(string[] args)
        {
			// Create cars, motorbikes and luxury cars in the user's vicinity
			var car1 = new Car {
				DistanceAwayInKm = 4.5
			};

			var car2 = new Car {
				DistanceAwayInKm = 1.2
			};

			var luxuryCar1 = new LuxuryCar {
				DistanceAwayInKm = 0.6
			};
			
			var extraLargeCar1 = new ExtraLargeCar {
				DistanceAwayInKm = 3.0
			};

			// 2.1. TODO: Create a list that can hold the above cars, extra large cars and luxury cars
		
			var cars = new List<Car>();

			cars.Add(car1);
			cars.Add(car2);
			//cars.Add(luxuryCar1);
			//cars.Add(extraLargeCar1);

			// 2.2. Check for nearby cars, extra large cars and luxury cars
			// by creating a foreach loop that goes through each of the cars, motorbikes and luxury cars created

			foreach (Car car in cars)
			{
				Console.WriteLine($"{car} has been created.");
			}
			// and calls their ReportDistance method
        }

    }
}
