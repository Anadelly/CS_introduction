// 1. С клавиатуры вводится целое число. Вывести квадрат числа

int num;
Console.Write("Enter an integer: ");
string a = Console.ReadLine();
num = Convert.ToInt32(a);
System.Console.Write("The square of the number '");
Console.Write(a);
Console.Write("' = ");
Console.Write(Math.Pow(num,2));