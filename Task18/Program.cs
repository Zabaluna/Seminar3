// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти");
// int quarter = Convert.ToInt32(Console.ReadLine());

// if (quarter >=1 && quarter <=4)
// {
// if ( quarter == 1) Console.WriteLine (" Диапазон X от 0 до + бесконечности, Диапазон Y от 0 до + бесконечности");
// if ( quarter == 2) Console.WriteLine (" Диапазон X от 0 до - бесконечности, Диапазон Y от 0 до + бесконечности");
// if ( quarter == 3) Console.WriteLine (" Диапазон X от 0 до - бесконечности, Диапазон Y от 0 до - бесконечности");
// if ( quarter == 4) Console.WriteLine (" Диапазон X от 0 до + бесконечности, Диапазон Y от 0 до - бесконечности");
// }
// else Console.WriteLine (" Вы ввели что-то не то. Всего четыре четверти");

void Coordinate(int Quarter)
{
    if ( Quarter == 1)
    {
        Console.WriteLine(" Диапазон X от 0 до + бесконечности, Диапазон Y от 0 до + бесконечности");
    }

    else if (Quarter == 2)
    {
        Console.WriteLine(" Диапазон X от 0 до - бесконечности, Диапазон Y от 0 до + бесконечности");
    }
    else if (Quarter == 3)
    {
        Console.WriteLine(" Диапазон X от 0 до - бесконечности, Диапазон Y от 0 до - бесконечности");
    }
    else if (Quarter == 4)
    {
        Console.WriteLine(" Диапазон X от 0 до + бесконечности, Диапазон Y от 0 до - бесконечности");
    }
    else
    {
        Console.WriteLine(" Вы ввели что-то не то. Всего четыре четверти");
    }
}

Console.WriteLine("Введите номер четверти");
int Quarter = Convert.ToInt32(Console.ReadLine());

Coordinate(Quarter);