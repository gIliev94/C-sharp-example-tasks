using CarProduction.Loggers;
using CarProduction.Vechicles;

namespace CarProduction.Builder
{
    public class CarBuilder : BaseVechileBuilder
    {
        public CarBuilder(ILogger logger) : base(logger)
        {
        }

        public override Vechicles.Vechicle Build()
        {
            CarVechicle car = new CarVechicle();

            car.Chassis = base.Chassis;
            car.Body = BodyType.Car;
            car.Engine = base.Engine;
            car.Doors = base.Doors;
            car.Windows = base.Windows;
            car.Wheels = base.Wheels;
            logger.Log(string.Format("Car completed {0}", car.ToString()));
            return car;
        }
    }
}
