// Task 2: Understanding Basic Syntax and Control Structures
class ArithmeticOperations
{
    static void Main1()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        int diff = num1 - num2;
        int product = num1 * num2;
        double quotient = num2 != 0 ? (double)num1 / num2 : 0;

        Console.WriteLine($"Sum: {sum}, Difference: {diff}, Product: {product}, Quotient: {quotient}");
        Console.WriteLine(sum % 2 == 0 ? "Sum is even" : "Sum is odd");
    }
}
