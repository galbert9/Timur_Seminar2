// Сгенерировать случайное трехзначное число и
// удалить вторую цифру этого числа 

int x = new Random().Next(100,1000);
Console.WriteLine($"Случайное число {x}");
int x1 = x/100;
int x2 = x % 10;
Console.WriteLine($" {x1}{x2}");

