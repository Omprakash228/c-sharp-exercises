int layer = 5;
int stars = 1;

for(int i = 1; i <= layer; i++)
{
    for(int sp = 0; sp < layer - i; sp++)
        Console.Write(" ");
    for(int s = 0; s < stars; s++)
        Console.Write("*");
    Console.WriteLine();
    stars += 2;
}