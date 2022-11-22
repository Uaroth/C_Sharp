Console.WriteLine("Здравствуйте. Введите элементы через пробел");
string element = Console.ReadLine();
string[] elements = element.Split(" ");
Console.WriteLine("Элементы, в которых не больше трёх символов: ");
for (int i = 0; i < elements.Length; i++)
{
    if (elements[i].Length < 4)
    {
        Console.Write($"{elements[i]} ");
    }
}