// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Две прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2");
// string str = Console.ReadLine();
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Первое уравнение: y = {k1} * x + {b1}");
Console.WriteLine($"Второе уравнение: y = {k2} * x + {b2}");

double X = 0;
double Y = 0;
if (k1 == k2)
{
    Console.WriteLine("Две прямые заданные уравнениями прямые");
}
else
{
    X = (b2 - b1) / (k1 - k2);
    Y = k1 * X + b1;
    Console.WriteLine($"Две прямые пересекаются в точке с координатами({X}; {Y})");
}
