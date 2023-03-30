// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

string a;
System.Console.Write("Введите любое целое число:");
a=Convert.ToString(Console.ReadLine()); 

char lastCharacter = a.Last(); // присвоение переменной lastCharacter значения последнего символа строки
System.Console.WriteLine(lastCharacter); // вывод на экран последней цифры числа введенного с клавиатуры
