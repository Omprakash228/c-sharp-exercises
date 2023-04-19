using System.Text;

Console.WriteLine("Enter an integer value");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    StringBuilder s = new StringBuilder();
    if (i % 3 == 0)
    {
        s.Append("fizz");
    }
    if (i % 5 == 0)
    {
        s.Append("buzz");
    }

    if (s.Length > 0)
    {
        Console.WriteLine(s);
    }
    else
    {
        Console.WriteLine(i);
    }
}
