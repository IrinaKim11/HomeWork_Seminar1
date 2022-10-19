// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите Xa: ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Xb: ");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Ya: ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Yb: ");
double Yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Za. Если ищите координаты на плоскости Za = 0: ");
double Za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Zb. Если ищите координаты на плоскости Zb = 0: ");
double Zb = Convert.ToDouble(Console.ReadLine());
double dis = 0;
dis = Math.Sqrt(Math.Pow(Xb-Xa,2)+ Math.Pow(Yb-Ya,2)+ Math.Pow(Zb-Za,2));
Console.WriteLine($"расстояние:  {dis}");
