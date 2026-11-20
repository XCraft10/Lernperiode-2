// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics;

using System.IO;
//Console.WriteLine("Hello, World!");

//Console clear
void Clear()
{ Console.Clear(); }

bool Escape = true;
int Spieler12 = 1;
int Spieler13 = 1;

//Menu
const string modi = ("\nHauptmenu\n\n\n1 = Spiel\n\n2 = Spieler\n\n3 = Musik\n\n4 = Challenge\n\nesc = Beenden");


//Arrays

List<string> Spieler = new();
//Spieler.Add("");

if (File.Exists("Spieler.txt"))
{
    Spieler = new List<string>(File.ReadAllLines("Spieler.txt"));
}


List<string> Musik = new();
//Musik.Add("");

List<string> Spiele = new();
//Musik.Add("");
if (File.Exists("Spiele.txt"))
{
    Spiele = new List<string>(File.ReadAllLines("Spiele.txt"));
}

List<string> Challenges = new();

if(File.Exists("Challenges.txt"))
{
    Challenges = new List<string>(File.ReadAllLines("Challenges.txt"));
}
//Musik.Add("");




//Static
//Spieler
List<string> AllSpieler()
{
    bool Bearbeitung = true;
    do
    {
        Clear();
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
                    string name = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Spieler.Add("Spieler " + Spieler12++);
                    }
                    else
                    {
                        Spieler.Add(name);
                    }
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine("Welcher Spieler möchten Sie entfernen?  (Nummer eingeben !)");
                    int Player = Convert.ToInt32(Console.ReadLine());
                    Spieler.RemoveAt(Player - 1);
                    break;

                case ConsoleKey.D3:
                    File.WriteAllLines("Spieler.txt", Spieler);
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
        Clear();
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
                    string name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {}
                    else
                    {
                        Challenges.Add(name);
                    }
                    break;

                case (ConsoleKey.D2):
                    Console.WriteLine("Welche Challenge möchten Sie entfernen ?");
                    int Challenge = Convert.ToInt32(Console.ReadLine());
                    Challenges.RemoveAt(Challenge - 1);
                    break;

                case (ConsoleKey.D3):
                    File.WriteAllLines("Challenges.txt", Challenges);
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

List<string> AllChallenge2()
{
    bool Bearbeitung = true;

    do
    {
        
        Console.WriteLine("\nChallenge\n");
        for (int i = 0; i < Challenges.Count; i++)
        {
            Console.WriteLine(i + 1 + " " + Challenges[i] + "\n");
        }
        try
        {
            Console.WriteLine("1 = Challenge Hinzufügen\n\n2 = Challenge Entfernen\n\n3 = Challenge Speichern");
            ConsoleKeyInfo Taste = Console.ReadKey(true);
            switch (Taste.Key)
            {
                case (ConsoleKey.D1):
                    Console.WriteLine("Geben Sie die Neue Challenge ein");
                    if (String.IsNullOrWhiteSpace(Console.ReadLine()))
                    {}
                    else
                    {
                        Challenges.Add(Console.ReadLine());
                    }
                    break;

                case (ConsoleKey.D2):
                    Console.WriteLine("Welche Challenge möchten Sie entfernen ?");
                    int Challenge = Convert.ToInt32(Console.ReadLine());
                    Challenges.RemoveAt(Challenge - 1);
                    break;

                case (ConsoleKey.D3):
                    File.WriteAllLines("Challenges.txt", Challenges);
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

        Clear();
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


        } while (Challenge);

    }


    void ChallengeAusführen()
    {
        Clear();
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
            AllChallenge2();
        }
    }

    void ChallengeOnly()
    {
        Clear();
        Random Challeng = new Random();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ihre Challenge ist " + Challenges[Challeng.Next(Challenges.Count)] + "\n");
        Console.ResetColor();
    }

    void ChallengeSpieler()
    {
        Clear();
        Random Challeng = new Random();
        Random Player = new Random();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Spieler[Player.Next(Spieler.Count)] + " ihre Challenge ist " + Challenges[Challeng.Next(Challenges.Count)] + "\n");
        Console.ResetColor();

    }

    // Challenge
    void RunChallenge()
    {
        bool Challenge = true;
        do
        {
            Clear();
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



List<string> AllGames()
{

    bool Bearbeitung = true;
    do
    {
        Clear();

        Console.WriteLine("Spiele\n");
        for (int i = 0; i < Spiele.Count; i++)
        {
            Console.WriteLine("\n" + (i + 1) + " " + Spiele[i]);
        }
        Console.WriteLine("\n1 = Spiel Hinzufügen\n\n2 = Spiel Entfernen\n\n3 = Spiele Speichern");
        ConsoleKeyInfo taste = Console.ReadKey(true);

        switch (taste.Key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("Geben sie den Namen des Spiels ein");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Ungültige Eingabe!");

                }
                else
                {
                    Spiele.Add(name);
                }


                break;

            case ConsoleKey.D2:



        }       //Weiterarbeiten
                //    h
                //    h
                //    h
                //    h




    } while (Bearbeitung) ;


};


void SpielRun()
{
    bool Spiel = true;
    do
    {
        Clear();

        Console.WriteLine("1 = Spiele verändern\n\n2 = Random Spiel auswälen\n\n3 = Zurück zur Auswahl");
        ConsoleKeyInfo taste = Console.ReadKey(true);

        switch (taste.Key)
        {

            case ConsoleKey.D1:
                AllGames();
                break;

            case ConsoleKey.D2:
                GamePlay();
                break;

            case ConsoleKey.D3:
                Spiel = false;
                break;

        }



    } while (Spiel);
}

void GamePlay()
{





}
// Startseite
    void Auswahl()
    {
        Clear();
        Console.WriteLine(modi);
        ConsoleKeyInfo taste = Console.ReadKey(true);

        switch (taste.Key)
        {

            case ConsoleKey.D1:

                SpielRun();
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
