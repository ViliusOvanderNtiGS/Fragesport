using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            //string replay = "";
            //while (replay != "Replay")
            //{
                
            
           
            string pog = "";
            //pog är lika med rätt svar

            int score = 0;
            Console.WriteLine("Välkommen till den bästa frågesporten");
            Console.WriteLine("Väm är ormen");
            Console.WriteLine("1: Korvberra ");
            Console.WriteLine("2: Din mor ");
            Console.WriteLine("3: Han som lägger på extra grillkrydda på sinna pomfritts");

            //     Fråga om att göra den här till en metod eftersom pog vill inte förstå att pog finns

            //pog = "";
            //while (pog != "1" && pog != "2" && pog != "3")
            //{
            //    Console.WriteLine("Skriv 1, 2 eller 3.");
            //    pog = Console.ReadLine();
            //}


            pog = "";
            while (pog != "1" && pog != "2" && pog != "3")
            {
                Console.WriteLine("Skriv 1, 2 eller 3.");
                pog = Console.ReadLine();
            }

            if (pog == "1")
            {
                score++;
                Console.WriteLine("Poäng; " + score);
                Console.WriteLine("Grattis det var rätt");

            }
            else if (pog == "2" || pog == "3")
            {
                Console.WriteLine("Fel Dum");
            }
            qReset();
            pog = "";


            Console.WriteLine("Vem röstade tant lövbiff på?");
            Console.WriteLine("1: Socialdemokraterna");
            Console.WriteLine("2: Nazisterna");
            Console.WriteLine("3: Örebropartiet");

            while (pog != "1" && pog != "2" && pog != "3")
            {
                Console.WriteLine("Skriv 1, 2 eller 3.");
                pog = Console.ReadLine();
            }

            if (pog == "2")
            {
                score++;
                Console.WriteLine("Poäng; " + score);
                Console.WriteLine("Grattis det var rätt");

            }
            else if (pog == "1" || pog == "3")
            {
                Console.WriteLine("fel dum");
            }

            qReset();
            pog = "";

            Console.WriteLine("Varför älskar Lukas Fortnite");
            Console.WriteLine("1: Han gillar det för att det är ett genuint bra spel enligt han");
            Console.WriteLine("2: Falskt. Han gillar inte fortnite för det är ett dåligt spel enligt han");
            Console.WriteLine("3: Han är Fortnite Lukas");

            while (pog != "1" && pog != "2" && pog != "3")
            {
                Console.WriteLine("Skriv 1, 2 eller 3.");
                pog = Console.ReadLine();
            }

            if (pog == "3")
            {
                score++;
                Console.WriteLine("Poäng; " + score);
                Console.WriteLine("Grattis det var rätt");

            }
            else if (pog == "1" || pog == "2")
            {
                Console.WriteLine("fel dum");
            }

            qReset();
            pog = "";

            Console.WriteLine("Det finns ingen mer fråga. Men du kan trycka på Enter igen för att se dina resultat.");
            Console.ReadLine();
            Console.Clear();

            if (score == 0)
            {
                Console.WriteLine("Jahopp");
                Console.WriteLine("Det gick inte så bra");
                Console.WriteLine("Poäng: " + score);
            }
            else if (score == 1)
            {
                Console.WriteLine("Ojdå");
                Console.WriteLine("Inte så många rätt svar du skev in där.");
                Console.WriteLine("Poäng: " + score);
            }
            else if (score == 2)
            {
                Console.WriteLine("Helt ok enlig mig");
                Console.WriteLine("66% är ett godtjänt betyg väll?");
                Console.WriteLine("Poäng: " + score);
            }
            else if (score == 3)
            {
                Console.WriteLine("Du hade alla rätt");
                Console.WriteLine("Det ser bra ut.");
                Console.WriteLine(@"          
             ___________
            '._==_==_=_.'
            .-\:      /-.
           | (|:.     |) |
            '-|:.     |-'
              \::.    /
               '::. .'
                 ) (
               _.' '._
              `*******`");
            

                Console.WriteLine("Poäng: " + score);
            }

            Console.WriteLine("Skriv Replay för att spela om.");

            Console.ReadLine();
            
            //}
        }
        static void qReset()
        {
            //string pog = "";
            Console.WriteLine("Tryck Enter för nästa fråga");
            Console.ReadLine();
            Console.Clear();
            //vill få in pog = ""; men vill inte fungera av någon anledning
            //pog = "";

        }



    }

}

