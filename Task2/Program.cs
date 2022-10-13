// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse (Console.ReadLine());

if(numberA == numberB) 
{
    Console.WriteLine("Числа равны");
}

else if(numberA < numberB)
{
    Console.WriteLine($"Наибольшее число: {numberB}");
}

else
{
    Console.WriteLine($"Наибольшее число: {numberA}");
}


