// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.Clear();
Random r = new Random();

Console.CursorVisible = false;
while (true)
{
    Console.SetCursorPosition(
        left: r.Next(Console.WindowWidth),
        top: r.Next(Console.WindowHeight)
    );
    Console.Write(r.Next(10));
    Thread.Sleep(1000);
}