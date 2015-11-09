using CarProduction.Vechicles;
using CarProduction.Loggers;

namespace CarProduction.Builder
{
    public abstract class BaseVechileBuilder
    {
        protected ILogger logger;
        public BaseVechileBuilder(ILogger logger)
        {
            this.logger = logger;
        }

        public int Wheels { get; set; }
        public ChassisType Chassis { get; set; }
        public bool Trailer { get; set; }
        public int Doors { get; set; }
        public EngineType Engine { get; set; }
        public int Windows { get; set; }
        public BodyType Body { get; set; }
        public abstract Vechicle Build();
    }
}
