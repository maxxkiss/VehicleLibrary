public class Helicopter : Vehicle
{
    public Helicopter(string brand, string model, IEngineAdapter engineAdapter, ICarrierAdapter carrierAdapter) : base(brand, model, engineAdapter, carrierAdapter)
    {

    }
}