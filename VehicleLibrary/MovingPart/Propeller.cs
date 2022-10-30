public class Propeller : MovingPart
{
    public Propeller(string manufacturer) : base(manufacturer)
    {

    }

    public override string TestBrakeSound()
    {
        return "Foof";
    }
}
