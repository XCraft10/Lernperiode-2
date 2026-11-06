// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

//Console.WriteLine("Hello, World!");

bool Escape = true;

//Menu
const string modi = ("\nHauptmenu\n\n\n1 = Spiel\n\n2 = Spieler\n\n3 = Musik\n\n4 = Challenge\n\nesc = Beenden");


//Arrays
List<string> Spieler = new();
//Spieler.Add("");

List<string> Musik = new();
//Musik.Add("");

List<string> Spiele = new();
//Musik.Add("");

List<string> Challenges = new();
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

//Challenges berarbeitung
List<string> AllChallenge()
{
    bool Bearbeitung = true;

    do
    {
        Console.WriteLine("\nChallenge\n");
        for (int i = 0; i < Challenges.Count; i++) 
        {
            Console.WriteLine(i+1 + " "+Challenges[i]+"\n");
        }
        try
        {
            Console.WriteLine("1 = Challenge Hinzufügen\n\n2 = Challenge Entfernen\n\n3 = Challenge Speichern");
            ConsoleKeyInfo Taste = Console.ReadKey(true);
            switch (Taste.Key)
            {
                case (ConsoleKey.D1):
                    Console.WriteLine("Geben Sie die Neue Challenge ein");
                    Challenges.Add(Console.ReadLine());
                    break;

                case (ConsoleKey.D2):
                    Console.WriteLine("Welche Challenge möchten Sie entfernen ?");
                    int Challenge = Convert.ToInt32(Console.ReadLine());
                    Challenges.RemoveAt(Challenge - 1);
                    break;

                case (ConsoleKey.D3):
                    Bearbeitung = false;
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;


            }

        }
        catch
        {
            Console.WriteLine("Ungültige Eingabe !");
        }


    } while (Bearbeitung);


    return Challenges;
}

//Chalenge Spielen

void PlayChallenge()
{

    ChallengeAusführen();
    bool Challenge = true;
    do
    {

        try
        {

       


            Console.WriteLine("\n1 = Neue Challenge\n\n2= Challenge Menu\n");
            ConsoleKeyInfo Taste = Console.ReadKey(true);
            switch (Taste.Key)
            {
                case ConsoleKey.D1:
                    ChallengeAusführen();
                    break;

                case ConsoleKey.D2:
                    Challenge = false;
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;
            }

        }
        catch
        {
            Console.WriteLine("Ungültige Eingabe");
        }


    }while (Challenge);

}


 void ChallengeAusführen()
    {
    if (Challenges.Count > 0)
    {
        if (Spieler.Count > 0)
        {
            ChallengeSpieler();
        }
        else
        {
            ChallengeOnly();
        }
    }
    else
    {
        Console.WriteLine("Sie haben noch keine Challenge hinzugefügt bitte machen sie das zuerst");
        AllChallenge();
    }
}

void ChallengeOnly()
{

    Random Challeng = new Random();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ihre Challenge ist " + Challenges[Challeng.Next(Challenges.Count)]+"\n");
    Console.ResetColor();
}

void ChallengeSpieler()
{

    Random Challeng = new Random();
    Random Player = new Random();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(Spieler[Player.Next(Spieler.Count)] + " ihre Challenge ist " + Challenges[Challeng.Next(Challenges.Count)]+"\n");
    Console.ResetColor();

}

// Challenge
void RunChallenge()
{
    bool Challenge = true;
    do
    {
        try
        {
            Console.WriteLine("Sie haben sich für den Modus Challenge entschieden was wollen sie nun machen\n\n1 = Spieler Hinzufügen\n\n2 = Challenge Hinzufügen\n\n3 = Zufalls Challenge Starten\n\n4 = Zurück zur Auswahl");
            //int Auswal = Convert.ToInt32(Console.ReadLine());
            ConsoleKeyInfo Taste = Console.ReadKey(true);

            switch (Taste.Key)
            {
                case ConsoleKey.D1:
                    AllSpieler();

                    break;
                case ConsoleKey.D2:
                    AllChallenge();

                    break;

                case ConsoleKey.D3:
                    PlayChallenge();
                    break;

                case ConsoleKey.D4:
                    Challenge = false;
                    break;



                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;

            }
        }
        catch { Console.WriteLine("Ungültige Eingabe"); }

    } while (Challenge);
}

void Auswahl()
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


}





Console.WriteLine("Herzlich Willkommen zu meiner Party App\n");

do
{
    Auswahl();
    //Console.WriteLine(modi);
    //ConsoleKeyInfo taste = Console.ReadKey(true);

    //switch (taste.Key)
    //{

        //case ConsoleKey.D1:

            //break;

        //case ConsoleKey.D2:
            //AllSpieler();
           
        //case ConsoleKey.D3:

            //break;

        //case ConsoleKey.D4:
            //RunChallenge();

            //break;

        //case ConsoleKey.Escape:
            //Escape = false;
            //break;
    //}



} while (Escape == true);
