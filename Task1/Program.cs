// Пройтись по всем файлам в папке

// path - путь к текущей папке, indent - отступы.
void CatalogInfo(string path, string indent = "")
{
  // Получаем информацию о директории.
  DirectoryInfo catalog = new DirectoryInfo(path);

  // Массив всех файлов, находящиеся в этой папке.
  DirectoryInfo[] catalogs = catalog.GetDirectories();
  for (int i = 0; i < catalogs.Length; i++)
  {
    Console.WriteLine($"{indent}{catalogs[i].Name}");
    CatalogInfo(catalogs[i].FullName, indent + " ");
  }
  
  // Список файлов текущей директории.
  FileInfo[] files = catalog.GetFiles();
  for (int i = 0; i < files.Length; i++)
  {
    Console.WriteLine($"{indent}{files[i].Name}");
  }
}

string path = @"C:\Users\Ильнар\OneDrive\Рабочий стол\Education\C#\Lection7_C";
CatalogInfo(path);
