namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            int b = a / 4;

            b = b * (b % 3);

            a = a - (b++ - 1);

            int x = a + b;
            Console.WriteLine(x);  
        }
    }
}
