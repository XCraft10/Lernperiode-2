// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

bool Escape = true;

//Menu
const string modi = ("Welchen Modus wollen Sie verwenden?\n\n1 = Spiel\n\n2 = Spieler\n\n3 = Musik\n\n4 = Challenge\n\nesc = Beenden");


//Arrays
List<string> Spieler = new();
//Spieler.Add("");

List<string> Musik = new();
//Musik.Add("");

List<string> Spiele = new();
//Musik.Add("");

List<string> Callenges = new();
//Musik.Add("");




//Static
//Spieler
List<string> AllSpieler()
{
    bool Bearbeitung = true;
    do
    {
        Console.WriteLine("\nSpieler\n");
        for (int i = 0; i < Spieler.Count; i++)
        {
            Console.WriteLine(i+1 + " "+Spieler[i] + "\n");
        }
        try
        {
            Console.WriteLine("1 = Spieler Hinzufügen\n\n2 = Spieler entfernen\n\n3 = Speichern");
            //int Modus = Convert.ToInt32(Console.ReadLine());
            ConsoleKeyInfo taste = Console.ReadKey(true);
            switch (taste.Key)//(Modus)
            {
                case ConsoleKey.D1:

                    Console.WriteLine("Geben sie den Namen des Neuen Spielers ein");

                    Spieler.Add(Console.ReadLine());
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine("Welcher Spieler möchten Sie entfernen?");
                    int Player = Convert.ToInt32(Console.ReadLine());
                    Spieler.RemoveAt(Player - 1);
                    break;

                case ConsoleKey.D3:
                    Bearbeitung = false;
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }
        }
        catch { Console.WriteLine("Ungültige Eingabe!"); }
    } while (Bearbeitung);
    return Spieler;
}

// Challenge
void RunChallenge()
{
    try
    {
        Console.WriteLine("Sie haben sich für den Modus Challenge entschieden was wollen sie nun machen\n\n1 = Spieler Hinzufügen\n\n2 = Challenge Hinzufügen\n\n3 = Zufalls Challenge Starten\n\n4 = Zurück zur Auswahl");
        int Auswal = Convert.ToInt32(Console.ReadLine());


        switch (Auswal)
        {
            case 1:
                AllSpieler();

                break;
            case 2:


                break;

            case 3:

                break;

            case 4:

                break;

            

            default:
                Console.WriteLine("Ungültige Eingabe");
                break;

        }
    }
    catch { Console.WriteLine("Ungültige Eingabe"); }

    
}








Console.WriteLine("Herzlich Willkommen zu meiner Party App\n");

do
{
    Console.WriteLine(modi);
    ConsoleKeyInfo taste = Console.ReadKey(true);

    switch (taste.Key)
    {

        case ConsoleKey.D1:

            break;

        case ConsoleKey.D2:
            AllSpieler();
            break;

        case ConsoleKey.D3:

            break;

        case ConsoleKey.D4:
            RunChallenge();

            break;

        case ConsoleKey.Escape:
            Escape = false;
            break;
    }



} while (Escape == true);
