// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

int a,b,z;

System.Console.WriteLine("С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b.");
System.Console.Write("Введите число а: ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
b=Convert.ToInt32(Console.ReadLine());

z=a%b;

if (z==0)
    System.Console.WriteLine("Число "+ a + " кратно " + "числу " + b);
else
    
    System.Console.WriteLine("Остаток от деления " + a + " на " + b + " = " + z);

