﻿// Дано число. Найти максимальную и минимальную цифру числа

int N=3145289;
int min,max;
min=10;
max=-1;
while(N!=0)
{
    int d=N%10;
    if (d>max) max=d;
    if (d<min) min=d;
    N/=10;
}

System.Console.WriteLine($"min={min} max={max}");

