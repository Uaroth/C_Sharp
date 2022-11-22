internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте. Введите элементы через пробел");
        string element = Console.ReadLine();
        string[] elements = element.Split(" ");
        int count = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i].Length < 4) count++;
        }

        string[] results = new string[count];
        int j = 0;

        Console.WriteLine("Элементы, в которых не больше трёх символов:");
        for (int i = 0; i < elements.Length; i++)
        {

            if (elements[i].Length < 4)
            {
                results[j] = elements[i];                
                Console.Write($"{results[j]} ");
                j++;
            }
        }
    }
}