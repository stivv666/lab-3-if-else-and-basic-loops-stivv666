static void Main ()
{
    Task1();
    Task2();
    Task3();
    Task4();
}

static void Task1()
{
    Console.WriteLine("Input x");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int number))
    {
        Console.WriteLine("Input R");
        string input2 = Console.ReadLine();
        if (int.TryParse(input2, out int number2))
        {
            Console.WriteLine("Input L");
            string input3 = Console.ReadLine();
            if (int.TryParse(input3, out int number3))
            {
                if (number >= number3)
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
        else
        {
            Console.WriteLine("Invalid input");
        }

    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}


static void Task2()
{
    string N = Console.ReadLine();
    if (int.TryParse(N, out int N1))
    {
        int sum = 0;
        for (int i = 0; i <= N1; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}

static void Task3()
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

static void Task4()
{
    int N;
    string? num = Console.ReadLine();
    bool re = int.TryParse(num, out N);

    if (!re)
    {
        Console.WriteLine("Invalid input");
    }

    int factorial = 1;

    for (int i = 1; i <= N; i++)
    {
        factorial *= i;
    }

    Console.WriteLine(factorial);

}

