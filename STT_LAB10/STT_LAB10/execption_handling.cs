// Task 5: Exception Handling
class ExceptionHandlingDemo
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
                throw new DivideByZeroException("Cannot divide by zero");

            Console.WriteLine($"Division result: {num1 / num2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }
    }
}