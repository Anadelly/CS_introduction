
// void Swap(int x, int y) //передача по значению (Value)
// {
//    int t = x;
//        x = y;
//        y = t; 
// }

void Swap(ref int x, ref int y) //передача по ссылке (References)
{
   int t = x;
       x = y;
       y = t; 
}

void Calculator (int a, int b, out int sum, out int sub) //передача по ссылке без присвоения первоначальных значений
{
    sum = a + b;
    sub = a - b;
}

int a = 4;
int b = 5;
int s, sb;
Calculator(a, b, out s, out sb);

System.Console.WriteLine($"{a} + {b} = {s}");
System.Console.WriteLine($"{a} - {b} = {sb}");

// System.Console.WriteLine($"a={a} b={b}");
// Swap(ref a, ref b);
// // a = a + b;
// // b = a - b;
// // a = a - b;
// System.Console.WriteLine($"a={a} b={b}");
