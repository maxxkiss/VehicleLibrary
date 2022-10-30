public class ElectricEngine : IEngineAdapter
{
    public int HPS { get; }
    public int CurrentPower { get; set; }

    public ElectricEngine(int hps)
    {
        HPS = hps;
        CurrentPower = 0;
    }

    public string StartMove()
    {
        CurrentPower++;
        MoveStarted.Invoke();
        return "Zhhh";
    }

    public void EndMove()
    {
        CurrentPower = 0;
    }

    public event Action MoveStarted = () => { };
}