
string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "asian" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length - 1);

Console.WriteLine($"Today we'll eat {snacks[randomIndex]}.");