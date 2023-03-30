// Вывести на экран кубы чисел от 1 до N
System.Console.Write("Введите любое положительное число:");
int a=Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=a;i++)
{
    int n=i*i*i;
    System.Console.WriteLine($"{i} в кубе = {n}");
}
