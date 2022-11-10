// Задать число и проверить его кратность одновременно 7 и 23
Console.WriteLine("Введите число");
int a = Convert.ToInt32 (Console.ReadLine());
int c = a % 7;
int d = a % 23;
if (c == 0 & d == 0)
Console.WriteLine("Кратно");
 else Console.WriteLine("Не кратно");