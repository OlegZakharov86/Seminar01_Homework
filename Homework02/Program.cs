namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите целое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе целое число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье целое число: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        int max = number1;
        if ( number1 > max )
        {
            Console.WriteLine($" {number1} максимальное число");
        }
        else if (number2 > max)
        {
            Console.WriteLine($"{number2} максимальное число");
        }
        else if (number3 > max)
        {
            Console.WriteLine($"{number3} максимальное число");
        }
        }
    }
}