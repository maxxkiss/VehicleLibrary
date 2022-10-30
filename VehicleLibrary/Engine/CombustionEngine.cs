public abstract class CombustionEngine : IEngineAdapter
{
    protected float Volume;
    protected int QuantityCylinders;

    public int HPS { get; }
    public int CurrentPower { get; set; }

    public CombustionEngine(float volume, int quantityCylinders, int hps)
    {
        Volume = volume;
        QuantityCylinders = quantityCylinders;
        HPS = hps;
        CurrentPower = 0;
    }

    public string StartMove()
    {
        CurrentPower++;
        MoveStarted.Invoke();
        return "Vroom";
    }

    public void EndMove()
    {
        CurrentPower = 0;
    }

    public event Action MoveStarted = () => { };
}