// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a,b,c;
int max;

System.Console.Write("Введите число a: ");
a=Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число b: ");
b=Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число c: ");
c=Convert.ToInt32(Console.ReadLine());

max=a;
if (max<b)
{
    max=b;
}
if (max<c)
{
    max=c;
}
System.Console.WriteLine($"Максимальное число = {max}");
