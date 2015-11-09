using CarProduction.Vechicles;
using CarProduction.Builder;
using CarProduction.Loggers;
using CarProduction.Vechicles.TemplateVehicles;
using CarProduction.Vechicles.TemplateVehicles.Cars;
using CarProduction.Vechicles.TemplateVehicles.Trucks;
using CarProduction.Vechicles.TemplateVechicles.Trucks;

namespace CarProduction.Facade
{
    public class VechicleCorporationFacade
    {
        /// <summary>Static method of the Facade class, suggests a template truck to the customer,based on his\her budget.
        /// <para>The <paramref name="budget"/> takes a decimal number.</para>
        /// <para>  Currently supported templates are Economy and MediumClass trucks</para>
        /// </summary>
        public static TemplateTruck BuildTruck(decimal budget)
        {
            if (budget <= 5000)
            {
                return new EconomyTruck();
            }

            return new MediumClassTruck();
        }

        /// <summary>Static method of the Facade class, suggests a template car to the customer,based on his\her budget.
        /// <para>The <paramref name="budget"/> takes a decimal number.</para>
        /// <para>  Currently supported templates are Economy and MediumClass cars</para>
        /// </summary>
        public static TemplateCar BuildCar(decimal budget)
        {
            if(budget <= 2000)
            {
                return new EconomyCar();
            }

            return new MediumClassCar();
        }

        public static TruckVechicle BuildTruck(int wheels, ChassisType chassisType, bool trailer, int doors, EngineType engine, BodyType body)
        {
            BaseVechileBuilder builder = new TruckBuilder(new ConsoleApplicationLogger());
            return (TruckVechicle)builder.Build();
        }
        public static CarVechicle BuildCar(int wheels, ChassisType chassisType, int doors, EngineType engine, int windows, BodyType body)
        {
            BaseVechileBuilder builder = new CarBuilder(new ConsoleApplicationLogger());
            return (CarVechicle)builder.Build();
        }
    }
}
