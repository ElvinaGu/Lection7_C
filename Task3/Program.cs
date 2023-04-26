// Обход разных структур
// ((4-2)*(1+3))/10

string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2    3     4    5    6    7    8    9    10   11

// Метод позволяющий делать обход
void InOrderTraversal(int pos = 1)
{
  if (pos < tree.Length)
  {
    // Левое "поддерево".
    int left = 2 * pos;
     // Правое "поддерево".
    int right = 2 * pos + 1;
    // Если левое "поддерево" существует и эл-т не является пустым, то запускаем обход.
    if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
    Console.WriteLine(tree[pos]);
    if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
  }
}

InOrderTraversal();