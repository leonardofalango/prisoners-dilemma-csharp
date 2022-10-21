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
M1.Run(Rodadas);
