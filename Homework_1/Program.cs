// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();
Console.WriteLine("Введите число обозначающее день недели");
int number = int.Parse (Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("выходной день");
}
else if (number <= 0 || number > 7)
{
    Console.WriteLine("Вы ввели неверное число");
}
else
{
    Console.WriteLine("будний день");
}