namespace CarProduction.Vechicles.TemplateVechicles.Trucks
{
    public class EconomyTruck:TemplateTruck
    {
        public EconomyTruck()
        {
            Wheels = 6;
            Chassis = ChassisType.TypeB;
            Trailer = true;
            Doors = 2;
            Engine = EngineType.Gasoline;
            Windows = 2;
            Body = BodyType.Truck;
        }
    }
}
