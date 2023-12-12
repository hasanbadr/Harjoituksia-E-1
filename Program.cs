using System;

class Program
{
    static void Main()
    {
        Console.Write("Syötä ikäsi: ");
        int ikä = int.Parse(Console.ReadLine());

        if (ikä < 0)
        {
            Console.WriteLine("Syötä positiivinen ikä.");
        }
        else if (ikä < 18)
        {
            Console.WriteLine($"{ikä} - näytät ikäistäsi nuoremmalta");
        }
        else
        {
            Console.WriteLine($"{ikä} - näytät ikäistäsi vanhemmalta");
        }
    }
}