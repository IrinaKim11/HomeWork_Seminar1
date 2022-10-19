// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int number = int.Parse (Console.ReadLine() ?? "0");
if (number == 1)
{
    Console.WriteLine("Диапазон координат: x (0; + бесконечность) y(0; + бесконечность)");
}
if (number == 2)
{
    Console.WriteLine("Диапазон координат: x (0; - бесконечность) y(0; + бесконечность)");
}
if (number == 3)
{
    Console.WriteLine("Диапазон координат: x (0; - бесконечность) y(0; - бесконечность)");
}
if (number == 4)
{
    Console.WriteLine("Диапазон координат: x (0; + бесконечность) y(0; - бесконечность)");
}