// See https://aka.ms/new-console-template for more information
using System.Diagnostics.SymbolStore;
using System.Globalization;

{
   
    List<int> numbers = new List<int>();


    while (true)
    {

        Console.WriteLine("Velkommen til. Her har du mulighed for at indtaste diverse tal og få dem i korrekt rækkefølge");
        Console.WriteLine("Du starter blot ved at trykke 'Enter' og du har derefter muligheden for at indtaste de tal du ønsker at bruge");

        Console.ReadKey();
        Console.Clear();



        
        Console.WriteLine("Indtast de tal du ønsker at bruge");

        while (true) {
            string input = Console.ReadLine();

            if (input == "#")
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }

            else
            {
                Console.WriteLine("Ugyldig indtastning, prøv lige igen. Du skal ikke bruge kommatal - så vild er jeg ikke");

            }

        }

        
        Console.WriteLine("De indtastet tal er:");
        foreach (int num in numbers)
        {
            Console.Write(num + ",");

        }


        Console.WriteLine();
        Console.WriteLine("Vil du bruge disse tal til at sætte i rækkefølge? ( Y / N )");

        string input2 = Console.ReadLine();

        if (input2 == "N")
        {
            Console.Clear();
            continue;
        }

        if (input2 == "Y")
        {
            Console.Clear();
            Console.WriteLine("De tal du har valgt at bruge: ");
            break;
        }

        else
        {
            Console.WriteLine("Du skal vælge mellem Y eller N....");
        }


    }

}

