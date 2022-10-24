
public class World
{
    public BasePlayer[] People { get; set; }
    public int TotalCoin { get; set; }
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
            this.TotalCoin += 2;
        }

        if (p1.IsPlaying() && !p2.IsPlaying())
        {
            p1.Coin += 4;
            p2.Coin -= 1;
            p1.Recebe(3);
            p2.Recebe(-1);
            this.TotalCoin += 3;
        }
        if (!p1.IsPlaying() && p2.IsPlaying())
        {
            p1.Coin -= 1;
            p2.Coin += 4;
            p1.Recebe(-1);
            p2.Recebe(4);
            this.TotalCoin += 3;
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

    public void Run(int rodadas)
    {
        Random rand = new Random();
        BasePlayer? p1;
        BasePlayer? p2;
        for (int i = 0; i < rodadas; i++)
        {
        do
        {
            p1 = this.People[rand.Next(0, this.People.Length)];
            p2 = this.People[rand.Next(0, this.People.Length)];
        } while (p1.Coin == 0 || p2.Coin == 0 || p1 == p2);
        this.Play(p1, p2);
        }
        Console.WriteLine($"Total de Moedas: {this.TotalCoin}");
        Console.WriteLine($"Faliram: {this.Poor}");
    }

    public World
    (
        int Coin,
        int GoodPlayers = 0,
        int BadPlayers = 0,
        int SpitefulPlayers = 0,
        int SafePlayers = 0,
        int RandomPlayers = 0,
        int FlipPlayers = 0,
        int ReflexPlayers = 0,
        int DetectivePlayers = 0,
        int ProbabilisticPlayers = 0,
        double ProbabilisticPlayers_percentage = 25
    )
    {
        int TotalPlayers = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers + DetectivePlayers + ProbabilisticPlayers;
        this.TotalCoin = TotalPlayers;
        this.People = new BasePlayer[TotalPlayers];
        for (int i = 0; i < GoodPlayers; i++)
        {
            GoodPlayer p = new GoodPlayer();
            p.Coin = Coin;
            this.People[i] = p;
        }
        for (int i = GoodPlayers; i < GoodPlayers + BadPlayers; i++)
        {
            BadPlayer p = new BadPlayer();
            p.Coin = Coin;
            this.People[i] = p;
        }
        for (int i = GoodPlayers + BadPlayers; i < GoodPlayers + BadPlayers + SpitefulPlayers; i++)
        {
            SpitefulPlayer p = new SpitefulPlayer();
            p.Coin = Coin;
            this.People[i] = p;
        }
        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers;
            i++
        )
        {
            SafePlayer p = new SafePlayer();
            p.Coin = Coin;
            this.People[i] = p;
        }

        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers;
            i++
        )
        {
            RandomPlayer p = new RandomPlayer();
            p.Coin = Coin;
            this.People[i] = p;
        }

        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers;
            i++
        )
        {
            RandomPlayer p = new RandomPlayer();
            p.Coin = Coin;
            this.People[i] = p;
        }

        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers;
            i++
        )
        {
            FlipPlayer p = new FlipPlayer();
            p.Coin = Coin;
            this.People[i] = p;
        }

        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers;
            i++
        )
        {
            ReflexPlayer p = new ReflexPlayer();
            p.Coin = Coin;
            this.People[i] = p;
        }
        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers + DetectivePlayers;
            i++
        )
        {
            DetectivePlayer p = new DetectivePlayer();
            p.Coin = Coin;
            this.People[i] = p;
        }
        for (
            int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers + DetectivePlayers;
            i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers + DetectivePlayers + ProbabilisticPlayers;
            i++
        )
        {
            ProbabilisticPlayer p = new ProbabilisticPlayer(ProbabilisticPlayers_percentage);
            p.Coin = Coin;
            this.People[i] = p;
        }

    }

}