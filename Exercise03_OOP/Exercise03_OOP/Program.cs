using System.CodeDom.Compiler;
using System.Runtime.Serialization.Formatters;

namespace Exercise03_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10);
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        static int[] GenerateNumbers(int length)
        {
            int[] numbers = new int[length];
            for(int i = 1; i <= length; i++)
            {
                numbers[i-1] = i;
            }
            return numbers;
        }

        static void Reverse(int[] numbers)
        {
            int l = numbers.Length;
            for(int i = 0; i < l/2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[l - i - 1];
                numbers[l - i - 1] = temp;
            }
        }

        static void PrintNumbers(int[] numbers)
        {
            for(int i = 0; i < numbers.Length;i++) {
                Console.WriteLine(numbers[i]);
            }
        }

    }
}