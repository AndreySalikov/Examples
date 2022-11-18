// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Собрать строку с числами от а до б

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersForRecursion(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersForRecursion(a + 1, b);
    else return String.Empty;
}
// Собрать строку с числами от b до a
string NumbersFor1(int a, int b)
{
    string result = String.Empty;
    for (int i = b; i >= a; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersForRecursion1(int a, int b)
{
    if (a <= b) return NumbersForRecursion1(a + 1, b) + $"{a} ";
    else return String.Empty;
}
// Сумма чисел до n
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
// Факториал n
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
// Возведение в степень 
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
// Показать слова и Т букв
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("word", new char[1]);

System.Console.WriteLine(PowerFor(2,10));
System.Console.WriteLine(PowerRec(2,10));
System.Console.WriteLine(PowerRecMath(2,10));

System.Console.WriteLine(FactorialFor(10));
System.Console.WriteLine(FactorialRec(10));

System.Console.WriteLine(SumFor(10));
System.Console.WriteLine(SumRec(10));

System.Console.WriteLine(NumbersFor(1, 10));
System.Console.WriteLine(NumbersForRecursion(1, 10));

System.Console.WriteLine(NumbersFor1(1, 10));
System.Console.WriteLine(NumbersForRecursion1(1, 10));

