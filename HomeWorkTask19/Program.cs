// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.WriteLine("Введите пятизначное число ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 9999 && Number < 100000)
{
    int Number1 = Number / 10000;
    int Number5 = Number % 10;

    int Number2 = (Number / 1000) % 10;
    int Number4 = (Number / 10) % 10;

    if (Number2 == Number4 && Number1 == Number5)
    {
        Console.WriteLine("Введенное число является палиндромом ");
    }
    else
    {
        Console.WriteLine("Введенное число НЕ является палиндромом ");
    }
}
else
    Console.WriteLine("Вы ввели не пятизначное число");

// Console.WriteLine($"{Number2},{Number4}");
// Console.WriteLine($"{Number1},{Number5}");