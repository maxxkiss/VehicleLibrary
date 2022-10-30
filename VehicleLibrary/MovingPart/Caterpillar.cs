public class Caterpillar : MovingPart
{
    public Caterpillar(string manufacturer) : base(manufacturer)
    {

    }

    public override string TestBrakeSound()
    {
        return "Shhh";
    }
}
