// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int userXa, int userYa, int userZa, int userXb, int userYb, int userZb)
{
    double LengthPoints = Math.Sqrt(Math.Pow((userXa - userXb), 2) + (Math.Pow((userYa - userYb), 2) + (Math.Pow((userZa - userZb), 2))));
    return LengthPoints;
}

Console.WriteLine("Введите X первой точки ");
int userXa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки ");
int userYa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z первой точки ");
int userZa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X второй точки ");
int userXb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки ");
int userYb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z второй точки ");
int userZb = Convert.ToInt32(Console.ReadLine());

double dist = Distance(userXa, userYa, userZa, userXb, userYb, userZb);

// double LengthPoints = Math.Sqrt(Math.Pow((userXa - userXb),2) + (Math.Pow((userYa - userYb),2) + (Math.Pow((userZa - userZb),2))));

// // Console.WriteLine($"Расстояние между точками равно {LengthPoints}");
Console.WriteLine($"Расстояние между точками равно {Math.Round(dist, 2, MidpointRounding.AwayFromZero)}");

