public class Vehicle : IVehicle
{
    private readonly string _brand;
    private string _model;
    public IEngineAdapter EngineAdapter;
    public ICarrierAdapter CarrierAdapter;

    public string Brand { get { return _brand; } }
    public string Model
    {
        get
        {
            return _model;
        }
        set
        {
            _model = value;
        }
    }

    public Vehicle(string brand, string model, IEngineAdapter engineAdapter, ICarrierAdapter carrierAdapter)
    {
        _brand = brand;
        _model = model;
        EngineAdapter = engineAdapter;
        CarrierAdapter = carrierAdapter;
    }

    public string Move()
    {
        return EngineAdapter.StartMove();
    }

    public string Stop()
    {
        EngineAdapter.EndMove();
        var result = CarrierAdapter.Brakes();
        return result;
    }
}