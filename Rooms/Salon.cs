namespace ProjetNarratif.Rooms
{
    internal class Salon : Room
    {
        internal override string CreateDescription() =>
@"Le salon est très calme, tellement calme que cela en devient effrayant. 
Sur la table à manger, il y a des [fruit]s. 
Sur le mur, il y a une [peinture] par ta fille. 
La [télévision] est éteinte. 
Tu trouves ça étrange et appelles ta fille plusieurs fois, mais personne ne répond.
Tu peux revenir dans ta [chambre].
";

        internal override void ReceiveChoice(string choice)
        {

            switch (choice)
            {
                case "fruit":
                    Console.WriteLine("妈妈说水果要洗洗再吃哦~ ");
                    Game.LoseHealth();
                    break;

                case "peinture":
                    Console.Write("La peinture représente une petite rivière ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("bleue");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\noù une fillette porte une petite jupe ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("rouge");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\net court dans un champ ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("vert");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\r\n\nCependant, le coin supérieur droit du tableau est manquant, ");
                        Console.WriteLine("\net on ne sait pas où se trouve la partie manquante de la peinture.");
                    break;

                case "télévision":
                    Console.WriteLine("Tu as allumé la télévision, mais il n'y avait aucun signal.");
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
        static void PrintColoredText(string text)
        {
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                if (word.ToLower() == "bleue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (word.ToLower() == "rouge")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (word.ToLower() == "vert")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = Console.ForegroundColor;
                }

                Console.Write(word + " ");
            }

            Console.WriteLine(); // Move to the next line after printing the colored text
            Console.ResetColor(); // Reset color to default
        }
    }
}
