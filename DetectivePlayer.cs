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
        if (value == -1)
            lastPlay = false;
        else
            lastPlay = true;
        round++;
    }
}