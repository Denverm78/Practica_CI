int[] Array = { 1, 22, 18, 4, 51, 6, 7, 18, 9 };

int n = Array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (Array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
