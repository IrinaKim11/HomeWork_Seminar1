// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse (Console.ReadLine() ?? "0");
string StringNumber = Convert.ToString(number);

if(number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("третья цифра: " + StringNumber[2]);
}