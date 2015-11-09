namespace CarProduction.Vechicles.TemplateVehicles.Cars
{
    public class MediumClassCar:TemplateCar
    {
        public MediumClassCar()
        {
            Wheels = 4;
            Chassis = ChassisType.TypeA;
            Trailer = false;
            Doors = 4;
            Engine = EngineType.Disel;
            Windows = 4;
            Body = BodyType.Car;
        }
    }
}
