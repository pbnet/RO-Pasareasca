using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Convertor Romana - Pasareasca by Andrei Emilian Rachita - andrei(at)rachita(dot)net");
        Console.WriteLine("======================================================================================");
        Console.WriteLine("Introduceti textul: ");
        string inputText = Console.ReadLine();

        Console.WriteLine("Textul in pasareasca este: ");
        Console.WriteLine(ConvertToPasareasca(inputText));

        Console.WriteLine("Apasati o tasta pentru a inchide fereastra...");
        Console.ReadKey();
    }

    static string ConvertToPasareasca(string inputText)
    {
        string pasareasca = "";

        foreach (char c in inputText)
        {
            switch (Char.ToLower(c))
            {
                case 'a':
                    pasareasca += "apa";
                    break;
                case 'e':
                    pasareasca += "epe";
                    break;
                case 'i':
                    pasareasca += "ipi";
                    break;
                case 'o':
                    pasareasca += "opo";
                    break;
                case 'u':
                    pasareasca += "upu";
                    break;
                default:
                    pasareasca += c;
                    break;
            }
        }

        return pasareasca;
    }
}
