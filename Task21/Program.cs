// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите X первой точки ");
int userXa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки ");
int userYa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X второй точки ");
int userXb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки ");
int userYb = Convert.ToInt32(Console.ReadLine());

double L = Math.Sqrt(Math.Pow((userXa - userXb),2) + (Math.Pow((userYa - userYb),2)));
Console.WriteLine($"Расстояние между точками равно {L}");