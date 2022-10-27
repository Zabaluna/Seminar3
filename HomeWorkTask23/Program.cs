// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

int Cube(int numbN);

for (int i = 1; i < numbN; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}

Console.WriteLine("Введите число ");
int numbN = Convert.ToInt32(Console.ReadLine());
Cube(numbN);


//  int Cube(int numbN);
// {
//     if (numbN > 0)
//     {
//         int i = 1;
//         while (i <= numberN)
//         {
//             Console.Write(Math.Pow(i, 3) + " ");
//             i++;
//         }
//     }
//     else
//     {
//             Console.WriteLine(" Введите число от 1");
//     }
// }

// Console.WriteLine("Введите число ");
// int numbN = Convert.ToInt32(Console.ReadLine());
// Cube(numbN);
