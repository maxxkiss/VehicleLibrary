public class Car : Vehicle
{
    public Car(string brand, string model, IEngineAdapter engineAdapter, ICarrierAdapter carrierAdapter) : base(brand, model, engineAdapter, carrierAdapter)
    {

    }
}
