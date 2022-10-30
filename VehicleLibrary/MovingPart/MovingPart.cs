public abstract class MovingPart
{
    protected string Manufacturer;
    protected int _currentSpeed = 0;

    public int CurrentSpeed 
    { 
        get { return _currentSpeed; }
        set { _currentSpeed = value; } 
    }

    public MovingPart(string manufacturer)
    {
        Manufacturer = manufacturer;
    }

    public int TestCurrentSpeed()
    {
        return CurrentSpeed;
    }

    public abstract string TestBrakeSound();
}