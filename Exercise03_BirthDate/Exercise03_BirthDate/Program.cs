DateTime birthDate = new DateTime(1995, 12, 11);

int ageInDays = (int)(DateTime.Now - birthDate).TotalDays;
Console.WriteLine("Age In Days: {0}", ageInDays);

DateTime anniversary = birthDate.AddDays(10000);
Console.WriteLine("Date after 10,000 days: {0}", anniversary);
