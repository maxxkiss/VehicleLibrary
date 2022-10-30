public class Tank : Vehicle
{
    public Tank(string brand, string model, IEngineAdapter engineAdapter, ICarrierAdapter carrierAdapter) : base(brand, model, engineAdapter, carrierAdapter)
    {

    }
}