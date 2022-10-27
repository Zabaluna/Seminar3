// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


double Distance(int userXa, int userYa, int userXb, int userYb)
{
    double L = 0;
    L = Math.Sqrt(Math.Pow((userXa - userXb), 2) + (Math.Pow((userYa - userYb), 2)));
    return L;
}
Console.WriteLine("Введите X первой точки ");
int userXa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки ");
int userYa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X второй точки ");
int userXb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки ");
int userYb = Convert.ToInt32(Console.ReadLine());

double distance = Distance(userXa, userYa, userXb, userYb);
Console.WriteLine($"Расстояние между точками равно {distance}");
