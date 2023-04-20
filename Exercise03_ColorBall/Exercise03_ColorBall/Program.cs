namespace Exercise03_ColorBall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball b = new Ball(5);
            b.Throw();
            Console.WriteLine(b.getThrowCount());
            b.Pop();
            b.Throw();
            Console.WriteLine(b.getThrowCount());
        }
    }
}