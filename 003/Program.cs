// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них. 
int a,b;
System.Console.WriteLine("С клавиатуры вводятся два числа a и b. Найти максимальное из них.");
System.Console.Write("Введите число а:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b:");
b=Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    System.Console.WriteLine($"{a} > {b}");
}
else
{
  System.Console.WriteLine($"{b} > {a}");  
}