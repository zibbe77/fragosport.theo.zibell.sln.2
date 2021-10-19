using System;

public class Toolbox
{
    public static int ingen(int currentPoints)
    {
        return currentPoints;
    }
    public static int AskQuestion(int qNum, string[] questionText, int currentPoints, string[] correctAnswer)
    {

        // skriv här frågan
        for (int i = qNum * 4; i < qNum * 4 + 3; i++)
        {
            Console.WriteLine(questionText[i]);
        }


        string player = "";
        while (player != "a" && player != "b" && player != "c")
        {
            player = Console.ReadLine().ToLower();

            if (player != "a" && player != "b" && player != "c")
            {
                Console.WriteLine("Du måste skriva A, B eller C");
            }

        }
        if (correctAnswer[qNum] == player)
        {
            Console.WriteLine("Du hade rätt");
            currentPoints += 1;
        }
        else
        {
            Console.WriteLine("Du hade fel");
        }
        return currentPoints;
    }

    public static int rättning(int antalr)
    {
        Console.WriteLine($"Du hade {antalr}");
        Console.WriteLine("vill du kör igen (Ja eller Nej)");
        string igen = "";
        igen = Console.ReadLine();
        if (igen == "Ja" | igen == "ja")
        {
            antalr = -1;
        }
        return antalr;

    }

}