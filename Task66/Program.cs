// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Введите первое число: ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int max = int.Parse(Console.ReadLine()!);


PrintNumbers(min, max, 0);

 void PrintNumbers(int m, int n, int sum)
 {
     sum = sum + n;
     if (n <= m)
    {
         Console.Write($" {sum} ");
         return;
     }
     PrintNumbers(m, n - 1, sum);

 }
