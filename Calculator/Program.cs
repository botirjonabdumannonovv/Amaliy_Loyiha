Console.WriteLine("Welcome to calculator!");

Console.WriteLine("Enter the first number: ");
var number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Select: *, /, +, -, % ");
var pattern = Console.ReadLine();

Console.WriteLine("Enter the second number: ");
var number2 = Convert.ToInt32(Console.ReadLine());

switch (pattern)
{
    case "*":
        Console.WriteLine($"Result: {number1 * number2}");
        break;
    case "/":
        Console.WriteLine($"Result: {number1 / number2}");
        break;
    case "+":
        Console.WriteLine($"Result: {number1 + number2}");
        break;
    case "-":
        Console.WriteLine($"Result: {number1 - number2}");
        break;
    case "%":
        Console.WriteLine($"Result: {number1 % number2}");
        break;
}