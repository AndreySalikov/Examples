// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; // создаем массив длиной 10 чисел по умалчанию он заполниться нулями
System.Console.WriteLine("Введи масив");
FillArray(array);
array[4] = 4;
array[6] = 4;
System.Console.WriteLine("Твой М");
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 5);
System.Console.Write("Индекс");
System.Console.WriteLine(pos);
