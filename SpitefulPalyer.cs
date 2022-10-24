public class SpitefulPlayer : BasePlayer // if someone cheated on spiteful Player, he will never play again
{
    private bool angry = false;
    public override bool IsPlaying()
    {
        if (angry)
            return false;
        return true;
    }
    public override void Recebe(int value)
    {
        if (value == -1)
        {
            angry = true;
        }
    }
}