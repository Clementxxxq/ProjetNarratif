namespace ProjetNarratif.Rooms
{
    internal class Cuisine:Room
    {
        internal static bool isKeyCollected;
        internal override string CreateDescription() =>
@"À côté du réfrigérateur dans la cuisine, il y a une porte menant au [cave].
Tu as trouvé un coffre est verrouillé avec un code [????].
Tu peux revenir dans le [salon].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "0509":
                    Console.WriteLine("Le coffre s'ouvre et tu obiens une clé.");
                    isKeyCollected = true;
                    break;

                case "cave":
                    if (!Cuisine.isKeyCollected)
                    {
                        Console.WriteLine("La porte est verrouillée.");
                    }
                    else
                    {
                        Console.WriteLine("Tu ouvres la porte avec ta clé et tu es entré dans la cave.");
                        Game.Transition<Cave>();
                    }
                    break;

                case "salon":
                    Console.WriteLine("Tu entres dans le salon.");
                    Game.Transition<Salon>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
