namespace CarProduction.Vechicles
{
    public enum ChassisType
    {
        TypeA,
        TypeB
    }

    public enum EngineType
    {
        Disel,
        Gasoline
    }

    public enum BodyType
    {
        Car,
        Truck
    }

    public abstract class Vechicle
    {
        public int Wheels { get; set; }
        public ChassisType Chassis { get; set; }

        public bool Trailer { get; set; }
        public int Doors { get; set; }
        public EngineType Engine { get; set; }
        public int Windows { get; set; }
        public BodyType Body { get; set; }
    }
}
