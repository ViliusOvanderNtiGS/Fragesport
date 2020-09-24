using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            string pog = "";
            //pog är lika med rätt svar

            int score = 0;
            Console.WriteLine("Välkommen till den bästa frågesporten");
            Console.WriteLine("Väm är ormen");
            Console.WriteLine("1: Korvberra ");
            Console.WriteLine("2: Din mor ");
            Console.WriteLine("3: Lukas");

            //     Fråga om att göra den hät till en metod eftersom pog vill inte förstå att pog finns

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
                Console.WriteLine("fel dum");
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

            Console.WriteLine("Lukas är fortnite?");
            Console.WriteLine("1: Ja");
            Console.WriteLine("2: Nej");
            Console.WriteLine("3: True");

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

            Console.ReadLine();
        }
        static void qReset()
        {
            Console.WriteLine("Tryck Enter för nästa fråga");
            Console.ReadLine();
            Console.Clear();
            //vill få in pog = ""; men vill inte fungera av någon anledning
        }

    }
}
