public class ProbabilisticPlayer : BasePlayer
{
    Random rand = new Random();
    private double play;
    private double Play
    {
        get { return play; }
        set 
        {
            if (value > 100 || value < 0)
                throw new Exception();
            else if (value < 1)
                value = value * 100;
            this.play = value;
        }
    }
    
    public ProbabilisticPlayer(double percentage)
    {
        this.Play = percentage;
    }

    public override bool IsPlaying()
    {
        double num = rand.NextDouble() * 100;
        if (num <= this.play)
        {
            return true;
        }
        return false;
    }

    public override void Recebe(int value) {}
} 