int[] array = { 11, 2, 31, 4, 5, 6, 17, 8};
int n = array.Length;
int find = 17;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
index++;
}