public class Suspension : ICarrierAdapter
{
    public int QuantityMovingParts { get; set; }
    public MovingPart[] MovingParts { get; set; }

    public IEngineAdapter RPM { get; set; }


    public Suspension(MovingPart[] movingParts)
    {
        MovingParts = movingParts;
        QuantityMovingParts = movingParts.Length;
    }

    public void Acceleration()
    {
        //RPM.MoveStarted += () =>
        //{
            foreach (var part in MovingParts)
                part.CurrentSpeed++;
        //};
    }

    public string Brakes()
    {
        int speedBeforeBrake;
        string brakeSound;

        if (MovingParts.Length == 0)
            return "...";

        speedBeforeBrake = MovingParts[0].TestCurrentSpeed();

        if (speedBeforeBrake == 0)
            return "...";

        brakeSound = MovingParts[0].TestBrakeSound();
        foreach (var part in MovingParts)
            part.CurrentSpeed = 0;
        return string.Concat(Enumerable.Repeat(brakeSound, speedBeforeBrake));
    }
}