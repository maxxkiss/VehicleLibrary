public class Wheel : MovingPart
{
    public Wheel(string manufacturer) : base(manufacturer)
    {

    }

    public override string TestBrakeSound()
    {
        return "Shhh";
    }
}
