using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new Bedroom());
game.Add(new Bathroom());
game.Add(new Salon());
game.Add(new Bedroom2());
game.Add(new Cave());
game.Add(new Cuisine());




while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

Console.WriteLine("FIN");
Console.ReadLine();