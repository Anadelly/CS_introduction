// Выяснить является ли число чётным.

int a;

System.Console.Write("Введите любое целое число: ");
a=Convert.ToInt32(Console.ReadLine());

if(a%2==0)
{
    System.Console.WriteLine($"{a} является чётным числом");
}
else
{
    System.Console.WriteLine($"{a} является нечётным числом");

}