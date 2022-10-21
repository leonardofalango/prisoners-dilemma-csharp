// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int Rodadas = 20000;
int GoodPlayers = 15;
int BadPlayers = 15;
int SpitefulPlayers = 15;
int SafePlayers = 15;
int RandomPlayers = 15;
int FlipPlayers = 15;
int ReflexPlayers = 15;

int TotalPlayers = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers;

World M1 = new World();
BasePlayer[] M1Players = new BasePlayer[TotalPlayers];




for (int i = 0; i < GoodPlayers; i++)
{
    GoodPlayer p = new GoodPlayer();
    p.Coin = 1;
    M1Players[i] = p;
}
for (int i = GoodPlayers; i < GoodPlayers + BadPlayers; i++)
{
    BadPlayer p = new BadPlayer();
    p.Coin = 1;
    M1Players[i] = p;
}
for (int i = GoodPlayers + BadPlayers; i < GoodPlayers + BadPlayers + SpitefulPlayers; i++)
{
    SpitefulPlayer p = new SpitefulPlayer();
    p.Coin = 1;
    M1Players[i] = p;
}
for (
    int i = GoodPlayers + BadPlayers + SpitefulPlayers;
    i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers;
    i++
)
{
    SafePlayer p = new SafePlayer();
    p.Coin = 1;
    M1Players[i] = p;
}

for (
    int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers;
    i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers;
    i++
)
{
    RandomPlayer p = new RandomPlayer();
    p.Coin = 1;
    M1Players[i] = p;
}

for (
    int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers;
    i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers;
    i++
)
{
    RandomPlayer p = new RandomPlayer();
    p.Coin = 1;
    M1Players[i] = p;
}

for (
    int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers;
    i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers;
    i++
)
{
    FlipPlayer p = new FlipPlayer();
    p.Coin = 1;
    M1Players[i] = p;
}

for (
    int i = GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers;
    i < GoodPlayers + BadPlayers + SpitefulPlayers + SafePlayers + RandomPlayers + FlipPlayers + ReflexPlayers;
    i++
)
{
    ReflexPlayer p = new ReflexPlayer();
    p.Coin = 1;
    M1Players[i] = p;
}




M1.People = M1Players;



BasePlayer p1;
BasePlayer p2;

Random rand = new Random();
for (int i = 0; i < Rodadas; i++)
{
    do
    {
        p1 = M1.People[rand.Next(0, TotalPlayers)];
        p2 = M1.People[rand.Next(0, TotalPlayers)];
    } while (p1.Coin == 0 || p2.Coin == 0 || p1 == p2);
    M1.Play(p1, p2);
}

Console.WriteLine(M1.TotalCoins);