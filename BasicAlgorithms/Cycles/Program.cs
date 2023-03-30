// цикл do ввести n от 0 до 10 с проверкой ввода

// { // область видимости переменных

// int n; 
// do // до тех пор пока
// {
//     n = Convert.ToInt32(Console.ReadLine());
// }
// while (n < 0 || n > 10); // цикл с постусловием, проверка ввода
// }

// цикл ДЛЯ
// вывести на экран числа от 1 до 10

// int i = 1;
// while(i < 10)
// {
//     System.Console.WriteLine(i);
//     i++;
// }

// for(int i = 1, k = 100; i <= 100 && k >=50; i++, k--)
// {
//     System.Console.WriteLine(i+ " "+k);
// }

string s="ASDFGH";
foreach(char c in s) // работает с коллекциями (реализующими интерфес IEnumerable) просмотр коллекции
{
    System.Console.WriteLine(c);
}