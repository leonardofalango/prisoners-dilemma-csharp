public class BadPlayer : BasePlayer // Bad Player never play
{
    public override bool IsPlaying() => false;
}