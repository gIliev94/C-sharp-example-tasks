namespace CarProduction.Vechicles.TemplateVehicles.Trucks
{
    public class MediumClassTruck:TemplateTruck
    {
        public MediumClassTruck()
        {
            Wheels = 8;
            Chassis = ChassisType.TypeB;
            Trailer = true;
            Doors = 2;
            Engine = EngineType.Disel;
            Windows = 2;
            Body = BodyType.Truck;
        }
    }
}
