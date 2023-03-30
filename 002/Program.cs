// С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго (блок-схема)

double a,b; // переменная вещественного типа



a=Convert.ToDouble(Console.ReadLine()); // конвертирование s строчного типа string   вещественный вид double
b=Convert.ToDouble(Console.ReadLine()); // второй способ приёма переменной
// b=Convert.ToDouble(s); // конвертирование в вещественный тип

// проверка условия

if (a*a==b)
    System.Console.WriteLine(b+" является квадратом "+a);
if (b*b==a)
    System.Console.WriteLine(a+" является квадратом "+b);    