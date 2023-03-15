// 4. По заданному с клавиатуры номеру дня недели вывести его название
int a;
Console.Write("Чтобы определить день недели введите число от 1 до 7:");
a=Convert.ToInt32(Console.ReadLine());


    if (0>=a)
    {
        System.Console.WriteLine("Введено неверное число! Программа завершена!");
    }
    if (7<a)
    {
        System.Console.WriteLine("Введено неверное число! Программа завершена!");
    }
    if (a==1)
    {
        System.Console.WriteLine("Первый день недели понедельник");
    }
    if (a==2)
    {
        System.Console.WriteLine("Второй день недели вторник");
    }
    if (a==3)
    {
        System.Console.WriteLine("Третий день недели среда");
    }
    if (a==4)
    {
        System.Console.WriteLine("Четвёртый день недели четверг");
    }
    if (a==5)
    {
        System.Console.WriteLine("Пятый день недели пятница");
    }
    if (a==6)
    {
        System.Console.WriteLine("Шестой день недели суббота");
    }
    if (a==7)
    {
        System.Console.WriteLine("Седьмой день недели воскресенье");
    }

