// Задать номер четверти, показать диапазоны для возможных координат

int x;

System.Console.Write("Введите номер четверти коррдинатной плоскости от 1 до 4: ");
x=Convert.ToInt32(Console.ReadLine());

if(x==1) System.Console.WriteLine("Х = от -1 до -бесконечности, Y = от 1 до +бесконечности");
if(x==2) System.Console.WriteLine("Х = от 1 до +бесконечности, Y = от 1 до +бесконечности");
if(x==3) System.Console.WriteLine("Х = от -1 до -бесконечности, Y = от -1 до -бесконечности");
if(x==4) System.Console.WriteLine("Х = от 1 до бесконечности, Y = от -1 до -бесконечности");