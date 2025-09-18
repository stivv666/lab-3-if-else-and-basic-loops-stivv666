namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        int Lint;
        int Rint;
        int xInt;
        int temp;

        string? Lstr = Console.ReadLine();
        bool resL = int.TryParse(Lstr, out Lint);

        if (!resL)
        {
            Console.WriteLine("Invalid input");
        }

        string? Rstr = Console.ReadLine();
        bool resR = int.TryParse(Rstr, out Rint);

        if (!resR)
        {
            Console.WriteLine("Invalid input");
        }

        if (Lint >= Rint)
        {
            temp = Lint;
            Lint = Rint;
            Rint = temp;
        }

        string? xString = Console.ReadLine();
        bool res1 = int.TryParse(xString, out xInt);

        if (res1)
        {
            if (xInt >= Lint && xInt <= Rint)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

    }
}