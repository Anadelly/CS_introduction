// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).


int ThirdDigit,result;
ThirdDigit=Convert.ToInt32(Console.ReadLine());
result=ThirdDigit/100;   
if (ThirdDigit<100)
    System.Console.WriteLine("NO");
else
    
    System.Console.WriteLine(result);
   