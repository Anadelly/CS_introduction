// Написать программу вычисления произведения чисел от 1 до N

System.Console.Write("Введите любое положительное число:");
int a=Convert.ToInt32(Console.ReadLine());
int b=1;
for(int i=1;i<=a;i++)
{
    b=b*i;
    
    //System.Console.WriteLine(b);
}

System.Console.WriteLine(b);