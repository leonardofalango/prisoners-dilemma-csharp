public class FlipPlayer : BasePlayer
{
    private bool lastPlay = false;
    public override bool IsPlaying()
    {
        if (lastPlay)
        {
            lastPlay = false;
            return false;
        }
        lastPlay = true;
        return true;
    }
}