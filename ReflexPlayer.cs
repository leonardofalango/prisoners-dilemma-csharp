public class ReflexPlayer : BasePlayer
{
    private bool lastPlay = true;
    public override bool IsPlaying()
    {
        return lastPlay;
    }
    public override void Recebe(int value)
    {
        if (value == -1)
            lastPlay = false;
        else
            lastPlay = true;
    }
}