// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int m = 6, n = 7;

List<List<int>> list = new List<List<int>>();

//Задание массива
Console.WriteLine("Исходный массив:");
for (int i = 0; i < m; i++)
{
    list.Add(new List<int>());
    for (int j = 0; j < n; j++)
        {
        list[i].Add(new Random().Next(10));
        Console.Write($"{list[i][j]} ");
        }
    Console.WriteLine();
}

int sumLine = 0;
int min=0;
int minIndex=0;
for (int i = 0; i < list.Count; i++)
{
    sumLine = 0;
    for (int j = 0; j < list[i].Count; j++)
    {
        sumLine += list[i][j];
    }
    Console.WriteLine($"Сумма элементов в строке {i}: {sumLine} ");
    if (i==0) 
    {
        min = sumLine;
        minIndex = 0;
    }
    else
    {
        if (sumLine < min) 
        {
            min = sumLine;
            minIndex = i;
        }
    }
}
//Вывод массива
Console.WriteLine($"Минимальная сумма {min} в строке {minIndex}");

