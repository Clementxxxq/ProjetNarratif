namespace ProjetNarratif.Rooms
{
    internal class Bedroom2 : Room
    {
        internal override string CreateDescription() =>
@"Tu te réveilles avec un frisson，sur le bureau de ton chambre.
Tu penses ：'Hier c'était vendredi，encore une nuit de travail tardive...'

Tu t'étires paresseusement et tu te diriges vers le [salon] ou la [toilette]
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "toilette":
                    Console.WriteLine("Tu entres dans la toilette.");
                    Game.Transition<Bathroom>();
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
