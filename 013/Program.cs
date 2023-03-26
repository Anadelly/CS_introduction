// Удалить вторую цифру целого числа введенного с клавиатуры.

int N=1234567888;
int countDigit=0;
int N1=N;
while(N!=0) // счетчик количества чисел в числе
{
    countDigit++;
    N/=10;
}
// находим вторую цифру числа
int d=N1/(int)Math.Pow(10,countDigit-2)%10; // N делим на 10 в степени 7-2 и получаем остаток от деления на 10
int d1=N1/(int)Math.Pow(10,countDigit-1)%10; // находим первую цифру
int n2=N1/(int)Math.Pow(10,countDigit-2); //находим последующие цифры
System.Console.WriteLine($"{d1}"+$"{n2}");