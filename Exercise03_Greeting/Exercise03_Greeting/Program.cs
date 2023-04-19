// 5. Greeting
DateTime current = DateTime.Now;
int hour = current.Hour;

if(hour < 12)
    Console.WriteLine("Good Morning");
if(hour >= 12 && hour <=16)
    Console.WriteLine("Good Afternoon");
if(hour > 16 && hour <= 20)
    Console.WriteLine("Good Evening");
if(hour > 20)
    Console.WriteLine("Good Night");


// 6. Count with variable increments
for(int i = 1; i <= 4; i++)
{
    int n = 0;
    Console.Write(n);
    while (n + i <= 24)
    {
        n += i;
        Console.Write(",{0}", n);
    }
    Console.WriteLine();
}