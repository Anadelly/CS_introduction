// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 
// !(X || Y)==!X && !Y

bool x=true;
bool y=false;

System.Console.WriteLine(x||x);
System.Console.WriteLine(x||y);
System.Console.WriteLine(y||x);
System.Console.WriteLine(y||y);

