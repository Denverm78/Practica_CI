void FillArray (int[] collection) //void ничего не возвращает и не нужен return
{
    int lenght = collection.Length;
    int index1 = 0;
    while (index1<lenght)
    {
        collection[index1] = new Random().Next(0,10);
        index1++;
    }
}

void PrintArray (int[] col)
{
  int count = col.Length;
    int index2 = 0;
    while (index2<count)
    {
        Console.WriteLine(col[index2]);
        index2++;
    }  
}

int [] array = new int[10];

FillArray (array);
PrintArray (array);
