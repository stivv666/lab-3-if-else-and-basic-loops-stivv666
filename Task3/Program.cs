
class Program
{
    static void Main(string[] args)
    {
        int numI;
        string? numS = Console.ReadLine();
        bool res1 = int.TryParse(numS, out numI);

        int sum = 0;

        if (!res1)
        {
            Console.WriteLine("Invalid input");
        }

        for (int i = 1; i <= numI; i++)
        {
            sum += i;
        }

        Console.WriteLine(sum);
    }
}
