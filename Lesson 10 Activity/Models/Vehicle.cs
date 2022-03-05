using System;

namespace RideShare.Models
{

    // TODO:
    // 1.1. Create a base class called Vehicle. Make the Car, ExtraLargeCar and LuxuryCar classes derive from this class.
    // 1.2. If it makes sense to move any properties to the base class to avoid duplication, then do so.
    // 1.3. Create a method on the base class to ReportDistance, and provide a default implementation, 
    //      which will be used by the Car and ExtraLargeCar classes.
    // 1.4. Have an implementation of the ReportDistance method that will be used just for the Luxury car.
    // 1.5. Ensure that the appropriate modifiers are used on your methods so that the default implementation
    //		of the ReportDistance method is used for the Car and ExtraLargeCar, but the LuxuryCar uses its own implementation of this method. 

    public class Vehicle
    {
        public double DistanceAwayInKm { get; set; }

        public virtual void ReportDistance()
        {
            Console.WriteLine($"There is a vehicle {DistanceAwayInKm}km away.");
        }
    }


    public class Car : Vehicle
    {
		
    }

    public class ExtraLargeCar : Vehicle
    {

    }

    public class LuxuryCar : Vehicle
    {

        public override void ReportDistance()
        {
            Console.WriteLine($"You're in for a smooth ride! There is a luxury vehicle {DistanceAwayInKm}km away.");
        }
    }
}