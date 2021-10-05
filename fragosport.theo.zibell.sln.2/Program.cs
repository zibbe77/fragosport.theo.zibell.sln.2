using System;
using System.IO;

string[] line = File.ReadAllLines(@"frogor.txt");
string[] line2 = File.ReadAllLines(@"svar.txt");

int fraga = 0;
int antalr = 0;
string a1 = "I";
bool bo2 = false;

int ii = 0; while (ii < 3)
{
    // skriv här frågan
    for (int i = fraga * 4; i < fraga * 4 + 3; i++)
    {
        Console.WriteLine(line[i]);

    }
    a1 = Console.ReadLine();

    //rättar

    if (a1 == "A" | a1 == "B" | a1 == "C" | a1 == "a" | a1 == "b" | a1 == "c")
    {
        for (int i = fraga * 3; i < fraga * 3 + 2; i++)
        {
            if (line2[i] == a1)
            {
                bo2 = true;
            }
        }
        if (bo2 == true)
        {
            Console.WriteLine("Du hade rätt");
            antalr += 1;
            bo2 = false;
        }
        else
        {
            Console.WriteLine("Du hade fel");
        }
        ii += 1;
        fraga += 1;
    }
    else
    {
        Console.WriteLine("Du måste skriva A, B eller C");
    }

    // kör igen

    if (fraga == 3)
    {
        Console.WriteLine($"Du hade {antalr}");
        Console.WriteLine("vill du kör igen (Ja eller Nej)");
        string igen = "a";
        igen = Console.ReadLine();
        if (igen == "Ja" | igen == "ja")
        {
            ii = 0;
            fraga = 0;
            antalr = 0;
        }
    }
}