// Сгенерировать случайное число и найти в нем Макс цифру
int x = new Random().Next(10,100);

int x1 = x/10;

int x2 = x % 10;

Console.WriteLine($"Случайное число {x}");
Console.WriteLine($"Первая цифра {x1}");
Console.WriteLine($"Вторая цифра {x2}");

if (x1 > x2) Console.WriteLine($" Максимум это {x1}");
else if (x1 < x2) Console.WriteLine($"Максимум равен {x2}");
else Console.WriteLine($"Обе цифры равны");