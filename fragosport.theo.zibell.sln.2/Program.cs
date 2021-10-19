using System;
using System.Collections.Generic;
using System.IO;

string[] line = File.ReadAllLines(@"frogor.txt");
string[] line2 = File.ReadAllLines(@"svar.txt");

//File.AppendAllText("svar.txt", "\nHej");

// List<string> frågor = new List<string>(line);
// Dictionary<string, int> stats = new Dictionary<string, int>();
// stats.Add("Strength", 22);
// System.Console.WriteLine(stats["Strength"]);
// System.Console.WriteLine(frågor.Count);


int fraga = 0;
int antalr = 0;

while (fraga < line2.Length)
{
    antalr = Toolbox.AskQuestion(fraga, line, antalr, line2);
    System.Console.WriteLine(antalr);
    fraga++;

    // kör igen

    if (fraga == line2.Length)
    {
        antalr = Toolbox.rättning(antalr);
        if (antalr == -1)
        {
            fraga = 0;
            antalr = 0;
        }
        nyfraga();
    }
}
//ny fråga

static void nyfraga()
{
    string igen = "";
    string igen1 = "";
    string igen2 = "";
    Console.WriteLine("vill du göra en fråga (Ja eller Nej)");
    igen = Console.ReadLine();
    if (igen == "Ja" | igen == "ja")
    {
        System.Console.WriteLine("skriv din fråga");
        igen = Console.ReadLine();
        File.AppendAllText("frogor.txt", "\n");
        File.AppendAllText("frogor.txt", $"\n{igen}");

        System.Console.WriteLine("skriv vad svar altentiv A ska vara");
        igen = Console.ReadLine();

        System.Console.WriteLine("skriv vad svars altentiv B ska vara");
        igen1 = Console.ReadLine();

        System.Console.WriteLine("skriv vad svars altentiv C ska vara");
        igen2 = Console.ReadLine();

        File.AppendAllText("frogor.txt", $"\nA --- {igen} | B --- {igen1} | C --- {igen2}");
        File.AppendAllText("frogor.txt", "\nSvar A, B eller C");

        System.Console.WriteLine("skriv vad svars ska vara (a, b eller c) små bokstäver");
        igen = Console.ReadLine();
        File.AppendAllText("svar.txt", $"\n{igen}");
    }
}

