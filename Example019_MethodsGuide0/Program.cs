using System;

int ii = new Random().Next(1,100);

int user;

do
{
    Console.Write("N: ");
    int.TryParse(Console.ReadLine(), out user);
    if (user > ii) Console.WriteLine("user > ii");
    if (user < ii) Console.WriteLine("user < ii");
}
while (user != ii);
Console.WriteLine("Красавчик");
Console.Write(ii);