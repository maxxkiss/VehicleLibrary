public abstract class MovingPart
{
    protected string _manufacturer;
    protected int _currentSpeed = 0;

    public int CurrentSpeed 
    { 
        get { return _currentSpeed; }
        set { _currentSpeed = value; } 
    }

    public MovingPart(string manufacturer)
    {
        _manufacturer = manufacturer;
    }

    public int TestCurrentSpeed()
    {
        return CurrentSpeed;
    }

    public abstract string TestBrakeSound();
}