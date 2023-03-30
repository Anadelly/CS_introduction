// Напишите подпрограмму нахождения расстояния между двумя точками
// метод (подпрограмма, функция)
// тип название аргументы
double Distance(double x1, double y1, double x2, double y2) // метод возвращает данные
{
   return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
}

void Pause() // метод не возвращает ничего
{
    Console.ReadKey(); //ожидание нажатия клавиши
}

// double x1=0,y1=0,x2=2,y2=2;
// double distance=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));

double distance=Distance(3,4,6,7); // вызов подпрораммы Distance
System.Console.WriteLine(distance);
System.Console.WriteLine(Distance(4,6,3,8));
Pause();