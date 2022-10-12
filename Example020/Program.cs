// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.Clear();

// using System;
// class PleaseSayUra
// {
//     static void Main()
//     {
//         System.Console.WriteLine("Ura");
//         Console.ReadLine();
//     }
// }

int count = 0;
while (count < 10)
{
    System.Console.Write(count + " ");
    count++;
}

System.Console.WriteLine();

int number = Convert.ToInt32(new Random().Next(-1,1));
System.Console.WriteLine(number);
if (number == 0)
{
    System.Console.WriteLine("TRUE");
}
else
{
    System.Console.WriteLine("FALSE");
}

for(int i = 0; i < 10; i++)
{
    System.Console.Write(-i+" ");
}

System.Console.WriteLine();
System.Console.WriteLine("Методы записи в масив и печати массва");

void FillArray (int[] collection)
{
    int length = collection.Length; 
    int index = 0;
    while (index < length)
    {
        collection[index] = Convert.ToInt32(new Random(). Next(99, 199));
        index = index +1; // index++
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        System.Console.Write(collection[index] + ", ");
        index++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
