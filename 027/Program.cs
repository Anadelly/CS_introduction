// Найти расстояние между точками в пространстве 2D

int a,b,c;

System.Console.Write("Введите точку а: ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите точку b:");
b=Convert.ToInt32(Console.ReadLine());

c=b-a;

System.Console.WriteLine($"Расстояние между точка a и b = {c} у.е");