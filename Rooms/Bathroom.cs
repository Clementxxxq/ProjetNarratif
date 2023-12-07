namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
        internal override string CreateDescription() =>
@"Dans la toilette, le [bain] est rempli d'eau chaude.
Le [miroir] devant toi affiche ton visage déprimé.
Tu peux revenir dans ta [chambre].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bain":
                    Console.WriteLine("Tu oses te laver avec de l'eau aussi chaude ? Tu vas te brûler !");
                    Game.LoseHealth();
                    break;

                case "miroir":
                    Console.Write("Tu aperçois les chiffres ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("1206 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("écrits sur la brume sur le miroir.");
                    break;

                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
