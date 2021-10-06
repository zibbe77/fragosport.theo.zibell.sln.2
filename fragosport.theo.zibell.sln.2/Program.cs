using System;
using System.IO;

string[] line = File.ReadAllLines(@"frogor.txt");
string[] line2 = File.ReadAllLines(@"svar.txt");

int fraga = 0;
int antalr = 0;

while (fraga < 3)
{
    antalr = Toolbox.AskQuestion(fraga, line, antalr, line2);
    System.Console.WriteLine(antalr);
    fraga++;

    // kör igen

    if (fraga == 3)
    {
        antalr = Toolbox.rättning(antalr);
        if (antalr == -1)
        {
            fraga = 0;
            antalr = 0;
        }
    }
}