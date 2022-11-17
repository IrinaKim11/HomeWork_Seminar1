// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void GetPoint(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if(k1==k2 && b1==b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if(k1==k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
    }
}

Console.Write("Введите числа через пробел b1 k1 b2 k2:  ");
double[] arr = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
double b1 = arr[0];
double k1 = arr[1];
double b2 = arr[2];
double k2 = arr[3];
GetPoint(b1, k1, b2, k2);



