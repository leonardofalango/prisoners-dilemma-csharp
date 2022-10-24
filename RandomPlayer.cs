public class RandomPlayer : BasePlayer
{
    Random rand = new Random();
    public override bool IsPlaying()
    {
        if (rand.Next(0, 1) == 1)
            return true;
        return false;
    }

}