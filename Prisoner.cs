public abstract class BasePlayer
{
    public int Coin { get; set; }
    public abstract bool IsPlaying();
    public virtual void Recebe(int value) { }
}


public class GoodPlayer : BasePlayer // Good Player always play
{
    public override bool IsPlaying()
    {
        return true;
    }

}

public class BadPlayer : BasePlayer // Bad Player never play
{
    public override bool IsPlaying()
    {
        return false;
    }

}

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

public class SafePlayer : BasePlayer // Safe will play until he has 1 coin
{
    public override bool IsPlaying()
    {
        if (Coin > 1)
            return true;
        return false;
    }

}

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
        return true;
    }
}

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

public class DetectivePlayer : BasePlayer
{
    private bool lastPlay;
    private bool isBad;
    private int round = 1;
    public override bool IsPlaying()
    {
        if (round == 1 || round == 3 || round == 4) 
            return true;
        
        else if (round == 2)
            return false;
        
        else
            if (isBad)
            {
                return false;
            }

            else
            {
                return lastPlay;
            }
    }

    public override void Recebe(int value)
    {
        if (round == 4 && value == -1)
            isBad = true;
        else if (round == 4 && value == 2)
            isBad = false;
        round++;
    }
}