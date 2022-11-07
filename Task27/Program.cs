// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = int.Parse (Console.ReadLine() ?? "0");
int result = SumNumbs(number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}");

int SumNumbs(int number)
{
    int count = Convert.ToString(number).Length;
    int num = 0;
    int sum = 0;
    int i = 0;
    while(i<count)
    {
        num = number - (number % 10);
        sum = sum + (number - num);
        number = number/10;
        i++;
    }
    return sum;
}