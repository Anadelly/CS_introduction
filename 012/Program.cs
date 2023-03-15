// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int a;
int d0,d1;

// ввод выполняется до тех пор пока не будет соблюдено условие 10<=a<=99

do {
    Console.Write("Введите число от 10 до 99: ");
    Int32.TryParse(Console.ReadLine(), out a);

} while((a > 99)|(a < 10));

    d0=a%10; // нахождение первого числа (отсчет справа)
    d1=a/10%10; // нахождение второго числа

    if (d0<d1)
        System.Console.WriteLine("Большее число = "+d1);

    else
        System.Console.WriteLine("Большее число = "+d0);
       



//int digit;
//do {
//    Console.WriteLine("Введите возраст: ");
//    Int32.TryParse(Console.ReadLine(), out digit);
//} while(digit < 14 || digit > 85);
//Console.WriteLine(digit);