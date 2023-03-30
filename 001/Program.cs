// 1. С клавиатуры вводится целое число. Вывести квадрат числа

int num;
Console.Write("Enter an integer: ");

num = Convert.ToInt32(Console.ReadLine());
System.Console.Write("The square of the number '");
Console.Write(num);
Console.Write("' = ");
Console.Write(Math.Pow(num,2));