// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Вид 1


Console.Clear();

void Method1()
{
    System.Console.WriteLine("Автор ...");
}

Method1();

// Вид 2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

Method2("Привет");

// Вид 2
void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;        
    }
}

Method2_1(msg: "Пока", count: 4); // Можем явно указыват значения для переменных
Method2_1("Порка", 4);
Method2_1(count: 4, msg: "Прополка");

// Метод 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Метод 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "ZV ");
Console.WriteLine(res);
System.Console.WriteLine(Method4(10, "ZV "));

// Метод 4_1

string Method4_1(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string resNew = Method4_1(10, "VZ ");
Console.WriteLine(resNew);
System.Console.WriteLine(Method4_1(10, "VZ "));

//

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine();
}

// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чертачками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "— Я думаю, — Cказал князь, улыбаяCь, — что, "
            + "ежели бы вас поCлали вмеCто нашего милого Винценгероде, "
            + "вы бы взяли приCтупом Cогласие прусского короля. "
            + "Вы так красноречивы. Выдадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

System.Console.WriteLine(text);
System.Console.WriteLine();
string newText = Replase(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replase(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replase(newText, 'C', 'с');
System.Console.WriteLine(newText);

// New example 

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();

// New example 
int [] arr = {6, 5, 4, 3, 2, 6, 7, 1, 1,};

void PrintArray(int[] array) // Метод, который выводит массив на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectiosSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array [i] = array[minPosition];
        array[minPosition] = temporary;
    }

}

PrintArray(arr);
SelectiosSort(arr);
PrintArray(arr);
