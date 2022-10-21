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
int DetectivePlayers = 15;

World M1 = new World(GoodPlayers, BadPlayers, SpitefulPlayers, SafePlayers, RandomPlayers, FlipPlayers, ReflexPlayers, DetectivePlayers);

Random rand = new Random();

BasePlayer p1;
BasePlayer p2;

for (int i = 0; i < Rodadas; i++)
{
    do
    {
        p1 = M1.People[rand.Next(0, M1.People.Length)];
        p2 = M1.People[rand.Next(0, M1.People.Length)];
    } while (p1.Coin == 0 || p2.Coin == 0 || p1 == p2);
    M1.Play(p1, p2);
}

Console.WriteLine($"Total de Moedas: {M1.TotalCoins}");
Console.WriteLine($"Faliram: {M1.Poor}");



World M2 = new World(0, 0, 0, 0, 0, 0, 0, 0);

for (int i = 0; i < Rodadas; i++)
{
    do
    {
        p1 = M2.People[rand.Next(0, M2.People.Length)];
        p2 = M2.People[rand.Next(0, M2.People.Length)];
    } while (p1.Coin == 0 || p2.Coin == 0 || p1 == p2);
    M2.Play(p1, p2);
}
Console.WriteLine($"Total de Moedas: {M2.TotalCoins}");
Console.WriteLine($"Faliram: {M2.Poor}");