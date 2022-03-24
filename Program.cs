 class PatternPrinting
 {
    /// <summary>
    /// Loops and Continue
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        //1 2 3 4 7 8 9 10      OK (1)
        //1 2 3 4 7 8 9 10      OK (2)
        //1 2 3 4 7 8 9 10      OK (3)
        //10 9 8 7 6 5 4 3 2 1  OK (4)
        //10 9 8 7 6 5 4 3 2 1  OK (5)
        //10 9 8 7 6 5 4 3      OK (6)
        //10 9 8 7 6 5 4 3 2 1  OK (7)
        //1 2 3 4 5 6 7 9 10    OK (8)

        int i;

        //################################  (1)
        for (i = 1; i < 11; i++)
        {
            if (i == 5 || i == 6)
            {
                continue;
            }
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        //################################ (2)
        i = 1;
        while (i < 11) {
            if (i != 5 && i != 6)
            {
                System.Console.Write(i + " ");
            }
            i++;
        }
        System.Console.WriteLine();

        //################################ (3)
        i = 1;
        do
        {
            if (i != 5 && i != 6) { 
                System.Console.Write(i + " ");
            }
            i++;
        }
        while (i < 11);
        System.Console.WriteLine();

        //################################ (4)
        i = 10;
        do
        {
            System.Console.Write(i + " ");
            i--;
        }
        while (i > 0);
        System.Console.WriteLine();

        //################################ (5)
        i = 10;
        while (i > 0)
        {
            System.Console.Write(i + " ");
            i--;
        }
        System.Console.WriteLine();

        //################################ (6)
        i = 10;
        while (i > 0)
        {
            if (i < 3)
            {
                break;
            }
            System.Console.Write(i + " ");
            i--;
        }
        System.Console.WriteLine();

        //################################ (7)
        for (i = 10; i > 0; i--)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        //################################ (8)
        for (i = 1; i < 11; i++)
        {
            if (i == 8) { 
                continue; 
            }
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
 }

