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
        Toolbox.nyfraga();
    }
}
