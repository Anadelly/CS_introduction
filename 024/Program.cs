// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int x,y;

System.Console.Write("Введите координату Х= ");
x=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y= ");
y=Convert.ToInt32(Console.ReadLine());

if(x<0 & y>0) System.Console.WriteLine("1 четверть");
if(x>0 & y>0) System.Console.WriteLine("2 четверть");
if(x<0 & y<0) System.Console.WriteLine("3 четверть");
if(x>0 & y<0) System.Console.WriteLine("4 четверть");
if(x==0 || y==0) System.Console.WriteLine("неверное значение");