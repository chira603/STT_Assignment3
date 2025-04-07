// Task 3: Implementing Loops and Functions
class Class1
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    static void Main2()
    {
        PrintNumbers();

        string input;
        do
        {
            Console.Write("Enter a number to find factorial (or type 'exit'): ");
            input = Console.ReadLine();
            if (input != "exit")
            {
                int num = int.Parse(input);
                Console.WriteLine($"Factorial of {num} is {Factorial(num)}");
            }
        } while (input != "exit");
    }
}
