namespace CarProduction.Vechicles.TemplateVehicles
{
    public class EconomyCar:TemplateCar
    {
        public EconomyCar()
        {
            Wheels = 4;
            Chassis = ChassisType.TypeA;
            Trailer = false;
            Doors = 2;
            Engine = EngineType.Gasoline;
            Windows = 4;
            Body = BodyType.Car;
        }
    }
}
