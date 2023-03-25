// По двум заданным числам проверять является ли одно квадратом другого.

int a=6;
int b=36;
int c=a*a;
int d=b*b;
System.Console.WriteLine("a="+a);
System.Console.WriteLine("b="+b);
if (c==b) System.Console.WriteLine($"b={b} является квадратом a={a}");
if (d==a) System.Console.WriteLine($"a={a} является квадратом b={b}");
if (c!=b & d!=a) System.Console.WriteLine("Не является");