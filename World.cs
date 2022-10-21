
public class World
{
    public BasePlayer[] People { get; set; }
    public int TotalCoins { get; set; }
    public int Round { get; set; }
    public int Poor { get; set; }
    public void Play(BasePlayer p1, BasePlayer p2)
    {
        // Console.WriteLine("_____________________________________");
        // Console.WriteLine($"\nPlayer 1: {p1.IsPlaying()} | Player 2: {p2.IsPlaying()}\nPlayer 1: {p1.Coin} | Player 2: {p2.Coin}");
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

        // Console.WriteLine("Resultado");
        // Console.WriteLine($"Player 1: {p1.Coin} | PLayer 2: {p2.Coin}");
        // Console.WriteLine("_____________________________________");
        
        if (p1.Coin == 0)
            Poor ++;
        if (p2.Coin == 0)
            Poor ++;
        Round++;
    }

    public World
    (
        int GoodPlayers,
        int BadPlayers,
        int SpitefulPlayers,
        int SafePlayers,
        int RandomPlayers,
        int FlipPlayers,
        int ReflexPlayers,
        int DetectivePlayers
    )
    {
        int TotalPlayers = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers + DetectivePlayers;
        this.People = new BasePlayer[TotalPlayers];
        for (int i = 0; i < GoodPlayers; i++)
        {
            GoodPlayer p = new GoodPlayer();
            p.Coin = 1;
            this.People[i] = p;
        }
        for (int i = GoodPlayers; i < GoodPlayers + BadPlayers; i++)
        {
            BadPlayer p = new BadPlayer();
            p.Coin = 1;
            this.People[i] = p;
        }
        for (int i = GoodPlayers + BadPlayers; i < GoodPlayers + BadPlayers + SpitefulPlayers; i++)
        {
            SpitefulPlayer p = new SpitefulPlayer();
            p.Coin = 1;
            this.People[i] = p;
        }
        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers;
            i++
        )
        {
            SafePlayer p = new SafePlayer();
            p.Coin = 1;
            this.People[i] = p;
        }

        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers;
            i++
        )
        {
            RandomPlayer p = new RandomPlayer();
            p.Coin = 1;
            this.People[i] = p;
        }

        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers;
            i++
        )
        {
            RandomPlayer p = new RandomPlayer();
            p.Coin = 1;
            this.People[i] = p;
        }

        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers;
            i++
        )
        {
            FlipPlayer p = new FlipPlayer();
            p.Coin = 1;
            this.People[i] = p;
        }

        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers;
            i++
        )
        {
            ReflexPlayer p = new ReflexPlayer();
            p.Coin = 1;
            this.People[i] = p;
        }
        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers + DetectivePlayers;
            i++
        )
        {
            DetectivePlayer p = new DetectivePlayer();
            p.Coin = 1;
            this.People[i] = p;
        }

    }

}