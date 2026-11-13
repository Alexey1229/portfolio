Console.WriteLine("Введите температуру в градусах Цельсиях: ");
int c = int.Parse(Console.ReadLine());
int f = (c * 9) / 5 + 32;
Console.WriteLine("Температура в градусах фаренгейта: " + f);