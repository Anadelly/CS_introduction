﻿// try
// {
// int a = Convert.ToInt32(Console.ReadLine());
// }

// catch(Exception ex)
// {
//     System.Console.WriteLine("Error!");
//     System.Console.WriteLine(ex.Message);
// }

int a;
bool f;
do
{
f = int.TryParse(Console.ReadLine(), out a);
if(f == false)
{
    System.Console.WriteLine("Error!");
}
else
{
    System.Console.WriteLine(a);
}
}

while(f == false);