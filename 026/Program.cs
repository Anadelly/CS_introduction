// Программа проверяет пятизначное число на палиндромом. Например:12321

int x;
int[] array = new int [5];
int count=0;
int result=0;
System.Console.Write("Введите пятизначное число: ");
x=Convert.ToInt32(Console.ReadLine());



while (count<5)
    {
    result=x%10;
    array[count]=result;
    //System.Console.WriteLine($" {array[count]} ");
    x=x/10;
    count++;
    }

if(array[0]==array[4] & array[1]==array[3]) System.Console.WriteLine("палиндром");
else System.Console.WriteLine("непалиндром");












