Random rnd = new Random();
int number = rnd.Next(1, 4);
Console.WriteLine(number);
int guessedNumber = int.Parse(Console.ReadLine());

if (guessedNumber < 1 || guessedNumber > 3)
    Console.WriteLine("Your guess is outside the range");
else if (guessedNumber == number)
    Console.WriteLine("You guessed it right!");
else if (guessedNumber < number)
    Console.WriteLine("Your guess is lower than the original number");
else
    Console.WriteLine("Your guess is greater than the original number");
