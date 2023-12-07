namespace ProjetNarratif.Rooms
{
    internal class jeu : Room
    {
        internal override string CreateDescription() =>
@"Tu entre dans la télé et il y a une personne mystérieuse devant toi.

Bienvenue dans ce jeu de devinettes ! Vous avez 3 essais pour deviner la réponse.
";
        internal override void ReceiveChoice(string choice)
        {
            JouerJeuDeDevinettes();
        }

        private static void JouerJeuDeDevinettes()
        {
            string reponseCorrecte = "ombre";
            int tentatives = 3;
            bool devineCorrectement = false;

            Console.WriteLine("Bienvenue dans ce jeu de devinettes ! Vous avez 3 essais pour deviner la réponse.");

            while (tentatives > 0)
            {
                Console.WriteLine("Elle est noir .");
                Console.Write("Quelle est votre réponse ? ");
                string proposition = Console.ReadLine();

                if (proposition.ToLower() == reponseCorrecte)
                {
                    devineCorrectement = true;
                    break;
                }
                else
                {
                    // Donner des indices différents en fonction des tentatives restantes
                    if (tentatives == 3)
                    {
                        Console.WriteLine("Indice 1 : Elle change avec la lumière.");
                    }
                    else if (tentatives == 2)
                    {
                        Console.WriteLine("Indice 2 : Elle est toujours avec vous mais jamais ne vous quitte.");
                    }
                    else if (tentatives == 1)
                    {
                        Console.WriteLine("Indice final : Vous la voyez au soleil, mais ce n'est jamais votre forme.");
                    }

                    tentatives--;
                    Console.WriteLine($"Faux ! Il vous reste {tentatives} essai(s).\n");
                }
            }

            if (devineCorrectement)
            {
                Console.WriteLine("\nFélicitations, vous avez deviné correctement !");
                Game.Transition<Salon>(); // Transition vers la classe Salon
            }
            else
            {
                Console.WriteLine("\nDésolé, vous avez utilisé tous vos essais. Le jeu est terminé. La réponse était 'ombre' !");
                Game.LoseHealth();
                Game.Transition<Salon>();
            }
        }
    }
}
