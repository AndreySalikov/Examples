// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string text = "(8,2) (2,3) (6,4) (4,5) (1,3)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);                

var data = text.Split(" ")
               .Select(item => item.Split(","))
               .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
               .Where(e => e.x % 2 == 0)
               .Select(point => (point.x*10, point.y+10))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    // Console.WriteLine(data[i].Item1*10);
    // Console.WriteLine(data[i].x*10);
    Console.WriteLine(data[i]);
    // for (int k = 0; k < data[i].Length; k++)
    // {
    //     System.Console.WriteLine(data[i][k]);
    // }
    // System.Console.WriteLine();
}