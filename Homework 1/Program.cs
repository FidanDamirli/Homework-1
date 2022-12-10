namespace Homework_1;
class Program
{
    static void Main(string[] args)
    {
        int number1,number2;
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        int sum = number1 + number2;
        Console.WriteLine($"{number1}+{number2}={sum}");

        Console.ReadKey();

    }
}

