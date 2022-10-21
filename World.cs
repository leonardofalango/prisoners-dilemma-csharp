
public class World
{
    public BasePlayer[] People { get; set; }
    public int TotalCoins { get; set; }
    public int Round { get; set; }
    public int Poor { get; set; }
    public void Play(BasePlayer p1, BasePlayer p2)
    {
        Console.WriteLine("_____________________________________");
        Console.WriteLine($"\nPlayer 1: {p1.IsPlaying()} | Player 2: {p2.IsPlaying()}\nPlayer 1: {p1.Coin} | Player 2: {p2.Coin}");
        if (p1.IsPlaying() && p2.IsPlaying())
        {
            p1.Coin += 1;
            p2.Coin += 1;
            p1.Recebe(1);
            p2.Recebe(1);
            this.TotalCoins += 2;
        }

        if (p1.IsPlaying() && !p2.IsPlaying())
        {
            p1.Coin += 4;
            p2.Coin -= 1;
            p1.Recebe(3);
            p2.Recebe(-1);
            this.TotalCoins += 4;
        }
        if (!p1.IsPlaying() && p2.IsPlaying())
        {
            p1.Coin -= 1;
            p2.Coin += 4;
            p1.Recebe(-1);
            p2.Recebe(4);
            this.TotalCoins += 4;
        }
        if (!p1.IsPlaying() && !p2.IsPlaying())
        {
            p1.Recebe(0);
            p2.Recebe(0);
        }

        Console.WriteLine("Resultado");
        Console.WriteLine($"Player 1: {p1.Coin} | PLayer 2: {p2.Coin}");
        Console.WriteLine("_____________________________________");
        
        if (p1.Coin == 0)
            Poor ++;
        if (p2.Coin == 0)
            Poor ++;
        Round++;
    }

}