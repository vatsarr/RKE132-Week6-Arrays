
string hello = " We are the champions! ";
hello = hello.Trim();

char firstLetter = hello[0];
hello = hello.Replace(hello[0], char.ToUpper(hello[0]));

int wordCounter = 1;

for (int i = 0; i < hello.Length; i++)
{
    if (char.IsWhiteSpace(hello[i]))
    {
        wordCounter++;
    }
}

Console.WriteLine($"Word count in {hello} is: {wordCounter} words.");