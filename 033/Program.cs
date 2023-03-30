// Возведите число А в натуральную степень B используя цикл


Int64 c=1; 
System.Console.Write("Введите число a:");
Int64 a=Convert.ToInt64(Console.ReadLine());
System.Console.Write("Введите число b:");
Int64 b=Convert.ToInt64(Console.ReadLine());

for(int i=0;i<b;i++)
{
    c*=a;
    //System.Console.WriteLine(c);
}

System.Console.WriteLine($"{a} в степени {b} = {c}");