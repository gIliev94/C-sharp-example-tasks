using CarProduction.Facade;
using CarProduction.Vechicles;
using System;

namespace CarProduction
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            // Customized orders 

            VechicleCorporationFacade.BuildCar(4, ChassisType.TypeA, 4, EngineType.Disel, 5, BodyType.Car);
            VechicleCorporationFacade.BuildTruck(8, ChassisType.TypeB, true, 4, EngineType.Gasoline, BodyType.Truck);

            Console.WriteLine();

            // Customer is not sure what he/she wants, they just have a budget in mind
            var unknownTruck = new TemplateTruck();
            var facadeRecommendedTruck = VechicleCorporationFacade.BuildTruck(4000);

            Console.WriteLine(facadeRecommendedTruck.GetType());

            var unknownCar = new TemplateCar();
            var facadeRecommendedCar = VechicleCorporationFacade.BuildCar(3000);

            Console.WriteLine(facadeRecommendedCar.GetType());

            Console.ReadKey();
        }
    }
}
