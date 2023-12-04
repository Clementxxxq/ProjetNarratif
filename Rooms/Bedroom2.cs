namespace ProjetNarratif.Rooms
{
    internal class Bedroom2 : Room
    {
        private bool passwordEntered = false;
        private string carnetPassword = "312";

        internal override string CreateDescription() =>
@"La pièce était propre, mais elle n'était pas là. 
Tu as remarqué un [carnet] posé sur la table.
Tu peux revenir dans le [salon].
";

        internal override void ReceiveChoice(string choice)
        {

            switch (choice)
            {
                case "carnet":
                    if (!passwordEntered)
                    {
                        Console.WriteLine("Le carnet ne s'ouvre pas, mais tu remarques trois boutons dessus, chacun de couleur rouge, verte et bleue.");
                        Console.WriteLine("Veuillez entrer le mot de passe :");
                        string passwordAttempt = Console.ReadLine();

                        if (passwordAttempt == carnetPassword)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Le carnet s'est ouvert !");
                            Console.ForegroundColor = ConsoleColor.White;
                            passwordEntered = true;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("5 octobre 2007, vendredi, beau temps. " +
                                "\n\tCe soir, papa travaille encore. " +
                                "\n\tEst-ce qu'il jouera avec moi demain ? " +
                                "\n\tJe lui dis depuis un mois. " +
                                "\n\tJ'ai préparé une surprise dans la cave, j'espère qu'il ne la trouvera pas. Hihi.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Mot de passe incorrect.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }                    
                    break;

                case "salon":
                    Console.WriteLine("Tu retournes dans le salon.");
                    Game.Transition<Salon>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
