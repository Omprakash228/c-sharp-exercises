namespace Exercise_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }

        static int Fibonacci(int value)
        {
            if(value == 1 || value == 2) { return 1; }

            return Fibonacci(value - 1) + Fibonacci(value - 2);
        }
    }
}