// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

void CatalogInfo(string path, string indent = "")
{
 DirectoryInfo catalogs = new DirectoryInfo(path);
 foreach (var currentCatalog in catalogs.GetDirectories())
 {
 Console.WriteLine($"{indent}{currentCatalog.Name}");
 CatalogInfo(currentCatalog.FullName, indent + " ");
 }
 foreach (var item in catalogs.GetFiles())
 {
 Console.WriteLine($"{indent}{item.Name}");
 }
}
string path = @"C:\Users\borzs\OneDrive\Рабочий стол\Программирование на C#\examples\RecusionDirectiry";
CatalogInfo(path);