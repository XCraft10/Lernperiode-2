using System.ComponentModel.Design;
string Frage = "A";
bool Nochmal = false;
bool catche = false;
bool Guess = false;
int Number;
int numberLengh = 100;
Console.WriteLine("Herzlich Wilkommen zu meinem Zahlenratespiel");



do
{
    Console.WriteLine("In einem wie grosen bereich wollen sie eien Zahl probieren herauszufinden");
    Console.WriteLine("(Zahl eingeben wie gross der bereich sein sollte es startet bei nul und geht dann bis zur ausgewälten zahl)");


    do
    {
        try
        {
            numberLengh = (Convert.ToInt32(Console.ReadLine()));
            catche = true;
        }
        catch
        {
            Console.WriteLine("Geben sie eine Zahl ein");
        }
    } while (catche == false);

    Number = new Random().Next(1, numberLengh);
    Console.WriteLine("Was denken sie ist ihre Zahl?");

    do
    {
        try
        {

            //Console.WriteLine(numberLengh);
            int Try = Convert.ToInt32(Console.ReadLine());


            //if check for in range




            if (Try <= 0)
            {
                Console.WriteLine("Geben sie eine Zahl über 0 ein");

            }
            else if (Try >= numberLengh)
            {
                Console.WriteLine("Bitte geben sie eine Zahl die inerhalb diesen 2 Zahlen ist");
                Console.WriteLine("0-" + numberLengh);
            }
            else
            {

                if (Try < Number)
                {
                    Console.WriteLine("Die gesuchte Zahl ist grösser");
                    Console.WriteLine("Versuchen sie es nochmals");
                }
                else if (Try > Number)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner");
                    Console.WriteLine("Versuchen sie es nochmals");

                }
                else if (Try == Number)
                {
                    Console.WriteLine("Glückwunsch sie haben die richtige Zahl gefunden");
                    Guess = true;
                }

                else
                {
                    Console.WriteLine("Geben sie bitte eine Zahl ein");
                }
            }
        }
        catch
        {
            Console.WriteLine("Geben sie eine Zahl ein!");
        }
    } while (Guess == false);
    Console.WriteLine("Wollen sie nochmal spielen?");
    Frage = Console.ReadLine();
    if (Frage == ("Ja"))
    { } 
    else if (Frage == ("ja"))
        { }
    else if (Frage == ("jA"))
    { }
    else if (Frage == ("JA"))
    { }
    else
    {
        Nochmal = true;
    }
} while (Nochmal  == false);

