// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 


System.Console.Write("Введите любое целое число:");
string a=Console.ReadLine(); 

char lastCharacter = a.Last(); // присвоение переменной lastCharacter значения последнего символа строки
System.Console.WriteLine(lastCharacter); // вывод на экран последней цифры числа введенного с клавиатуры
