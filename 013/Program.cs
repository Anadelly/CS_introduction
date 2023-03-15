// Удалить вторую цифру целого числа введенного с клавиатуры.


//d1=a/10%10; // нахождение второго числа

internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.Write("Введите целое число: ");
        string a = Console.ReadLine();
        a = a.Remove(1,1);
        num = Convert.ToInt32(a);

        Console.WriteLine(num);
    }
}