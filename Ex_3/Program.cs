// На входе два числа. Проверить кратность, если нет,
// вывести остаток от деления 19:22

Console.WriteLine("Введите первое число");  
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число"); 
int b = Convert.ToInt32 (Console.ReadLine());
int c = a % b;

if (c == 0) Console.WriteLine("Числа кратные");
else Console.WriteLine("Числа не кратные, остаток = "+c);
