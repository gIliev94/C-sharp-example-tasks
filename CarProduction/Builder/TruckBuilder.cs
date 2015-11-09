using CarProduction.Vechicles;
using CarProduction.Loggers;

namespace CarProduction.Builder
{
    public class TruckBuilder : BaseVechileBuilder
    {
        public TruckBuilder(ILogger logger) : base(logger)
        {
            
        }

        public override Vechicles.Vechicle Build()
        {
            TruckVechicle truck = new TruckVechicle();
            truck.Engine = base.Engine;
            truck.Body = BodyType.Truck;
            truck.Chassis = base.Chassis;
            truck.Trailer = base.Trailer;
            truck.Doors = base.Doors;
            truck.Wheels = base.Wheels;

            logger.Log(string.Format("Truck completed {0}", truck.ToString()));

            return truck;
        }
    }
}
