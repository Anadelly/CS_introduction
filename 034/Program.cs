// 34. Определить количество цифр в числе. Сделать подпрограммую

int Counter(int n)
{
    if (n==0) return 1; // пограничный случай

    int counter=0; // счётчик
    while(n!=0)
    {
    n/=10;
    counter++;
    }
    return counter;
}
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Counter(N));