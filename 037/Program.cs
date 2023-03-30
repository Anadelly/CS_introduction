// показать кубы чисел заканчивающихся на четную цифру

bool Test(int n) // метод проверяющий на истинность значения n
{
    return n%2==0;
    // if (n%2==0)
    //     return true;
    // else
    //     return false;
}

Random random;//описали переменную random
random=new Random();//создали объект
// Random random=new Random();
for(int i=0;i<10;i++)
{
    int a=random.Next(1,100);
    //int b=(int)Math.Pow(a,3);
    if(Test(a))
        System.Console.WriteLine($"{a}, {a=(int)Math.Pow(a,3)}");
}