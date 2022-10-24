public abstract class BasePlayer
{
    public int Coin { get; set; }
    public abstract bool IsPlaying();
    public virtual void Recebe(int value) { }
}

