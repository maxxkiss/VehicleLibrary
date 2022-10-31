public interface ICarrierAdapter
{
    public int QuantityMovingParts { get; set; }
    public MovingPart[] MovingParts { get; set; }
    public IEngineAdapter RPM { get; set; }

    public string Brakes();
}