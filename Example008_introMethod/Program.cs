// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Знакомство с функциями
// Найти максимум из 9 чисел
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 1123;
int b1 = 11;
int c1 = 13;
int a2 = 331;
int b2 = 45;
int c2 = 86;
int a3 = 44;
int b3 = 99999;
int c3 = 75;

int max = Max(
        Max(a1, b1, c1),
        Max(a2, b2, c2),
        Max(a3, b3, c3)
        );


// Var3

// int max = Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3));


// Var 2
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// Var 1
// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

System.Console.WriteLine(max);