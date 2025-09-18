namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        int x1;
        int x2;
        int y1;
        int y2;

        Console.WriteLine("Coordinates a first object");
        string? x1S = Console.ReadLine();
        string? y1S = Console.ReadLine();

        Console.WriteLine("Coordinates a second object");
        string? x2S = Console.ReadLine();
        string? y2S = Console.ReadLine();

        bool res1 = int.TryParse(x1S, out x1);
        if (!res1 || x1 <= 0)
        {
            Console.WriteLine("Invalid input");
        }

        bool res2 = int.TryParse(y1S, out y1);
        if (!res2 || y1 <= 0)
        {
            Console.WriteLine("Invalid input");
        }

        bool res3 = int.TryParse(x2S, out x2);
        if (!res3 || x2 <= 0)
        {
            Console.WriteLine("Invalid input");
        }

        bool res4 = int.TryParse(y2S, out y2);
        if (!res4 || y2 <= 0)
        {
            Console.WriteLine("Invalid input");
        }

        if (x1 == x2 || y1 == y2)
        {
            Console.WriteLine("Attack");
        }
        else
        {
            Console.WriteLine("Not attack");
        }

    }
}
