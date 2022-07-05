namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        // int div = number/2;
        while(count < number)
        if ( count % 2 == 0 )
        {
            Console.WriteLine($" {count} ");
            count = count + 1;
        }
        else
        {
            count = count + 1;
        }
        
        }
    }
}
