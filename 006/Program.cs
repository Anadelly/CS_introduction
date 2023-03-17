// Написать программу вычисления значения функции y = sin(a). (Класс Math). 

double x;
System.Console.Write("Введите значение х: ");
x = Convert.ToDouble(Console.ReadLine());
double y = Math.Sin(x);
System.Console.WriteLine("Значение sin(x)="+y);
