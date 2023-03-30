// Подсчитать сумму цифр в числе. Сделать подпрограмму.

int Sum(int a)
{
int kol=a;
int sum=0;
int counter=0; // счётчик
    while(kol!=0)
    {
    kol/=10;
    counter++;
    }

for(int i=0;i<counter;i++)
{
    int result=a%10;
    a/=10;
    //System.Console.WriteLine(a);
    sum+=result;
    //System.Console.WriteLine(sum);
}
return sum;
}
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(N));