namespace ProjetNarratif.Rooms
{
    internal class Salon : Room
    {
        private bool passwordEntered = false; 

        private string Bedroom2Password = "1206";

        internal override string CreateDescription() =>
@"Le salon est très calme, tellement calme que cela en devient effrayant. 
Sur la table à manger, il y a des [fruit]s. 
Sur le mur, il y a une [peinture] par ta fille. 
La [tv] est éteinte. 
La porte de la [cuisine] est ouverte.
Tu trouves ça étrange et appelles ta fille plusieurs fois.
Alors, tu te rends à la porte de la [chambre2] de ta fille et tu frappes, mais personne ne répond.
Tu peux revenir dans ta [chambre].
";

        internal override void ReceiveChoice(string choice)
        {

            switch (choice)
            {
                case "fruit":
                    Console.WriteLine("Ma mère dit qu'il faut laver les fruits avant de les manger !");
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

                case "tv":
                    Console.WriteLine("Tu as allumé la télévision.");
                    Game.Transition<jeu>();
                    break;

                case "chambre2":
                    if (!passwordEntered)
                    {
                        Console.WriteLine("La porte est verrouillée et nécessite un mot de passe.");
                        Console.WriteLine("Veuillez entrer le mot de passe :");
                        string passwordAttempt = Console.ReadLine();

                        if (passwordAttempt == Bedroom2Password)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Mot de passe correct. La porte s'ouvre.");
                            Console.ForegroundColor = ConsoleColor.White;
                            passwordEntered = true;
                            Game.Transition<Bedroom2>();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Mot de passe incorrect. La porte reste verrouillée.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.WriteLine("La porte est déjà ouverte.");
                        Game.Transition<Bedroom2>();
                    }
                    break;

                case "cuisine":
                    Console.WriteLine("Tu entre dans la cuisine.");
                    Game.Transition<Cuisine>();
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
