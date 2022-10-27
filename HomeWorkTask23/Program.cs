// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число ");
int numbN = Convert.ToInt32(Console.ReadLine());

if (numbN <= 0)
{
    Console.WriteLine("Ваше число меньше нуля");
}
else
{
    for (int i = 1; i < numbN; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.WriteLine($"{Math.Pow(numbN, 3)}, ");
}


