namespace ProjetNarratif.Rooms
{
    internal class Cave : Room
    {
        internal override string CreateDescription() =>
@"Le cave est plongé dans l'obscurité
L'escalier vieux émettait des grincements
Te donnant pour la première fois une sensation de peur à la maison.

Tu es entré prudemment dans le cave.
Il y avait trois boîtes disposées au centre.
L'un est [pauvre], l'autre est [ordinaire] et l'autre est très [jolie]
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "pauvre":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La boîte contient un tas de documents." +
                        "Continuez à travailler!!!");
                    Game.Finish();
                    break;

                case "ordinaire":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La boîte contient un fragment de dessin représentant un cerf-volant volant dans le ciel bleu.");
                    Console.WriteLine("Tu te rends soudain compte que tu avais promis d'emmener ta fille faire du cerf-volant il y a un mois, " +
                        "mais tu as oublié à cause d'un travail très chargé.");
                    Console.WriteLine("Au réveil, déterminé, tu décides d'organiser une journée spéciale pour faire du cerf-volant avec ta fille. " +
                        "Tu te diriges vers sa chambre, prêt à rattraper le temps perdu et à créer des souvenirs précieux. ");
                    Game.Finish();
                    break;

                case "jolie":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La boîte contient une toupie qui ne cesse de tourner..." +
                        "Tu es piégé ici pour toujours...");
                    Game.Finish();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
