public interface IEngineAdapter
{
    public int HPS { get; }
    public int CurrentPower { get; set; }

	public string StartMove();
	public void EndMove();

    public event Action MoveStarted;
}