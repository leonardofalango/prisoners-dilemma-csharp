public class SafePlayer : BasePlayer // Safe will play until he has 1 coin
{
    public override bool IsPlaying()
    {
        if (Coin > 1)
            return true;
        return false;
    }

}