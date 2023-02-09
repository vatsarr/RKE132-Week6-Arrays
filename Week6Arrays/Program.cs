
string[] fruits = { "apple", "orange", "banana" };

Console.WriteLine(fruits.Length);

//for (int i = 0; i < fruits.Length; i++)
//{
//    Console.WriteLine(fruits[i]);
//}

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

for (int i = 0; i < fruits.Length; i++)
{
    fruits[i] = fruits[i].Replace(fruits[i][0], char.ToUpper(fruits[i][0]));
    Console.WriteLine(fruits[i]);
}