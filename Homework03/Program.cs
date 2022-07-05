namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int div = number/2;
        if ( div % 2 == 0 )
        {
            Console.WriteLine($" {number} четное число");
        }
        else 
        {
            Console.WriteLine($"{number} нечетное число");
        }
        
        }
    }
}
