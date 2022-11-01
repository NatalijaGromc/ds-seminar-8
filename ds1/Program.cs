// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
//Сортировка массива
bool isSortedLine = false;
int firstElem = 0;
int temp;
for (int i = 0; i < list.Count; i++)
{
    isSortedLine = false;
    firstElem = 1;
    while (isSortedLine == false)
        {
        isSortedLine = true;
        for (int j = firstElem; j < list[i].Count; j++)
        {
            if (list[i][j] > list[i][j-1])
            {
                temp = list[i][j];
                list[i][j] = list[i][j-1];
                list[i][j-1] = temp;
                isSortedLine = false;
            }
 
        }
        }
}
//Вывод массива
Console.WriteLine();
Console.WriteLine("Массив с сортированными элементами строк по убыванию:");
for (int i = 0; i < list.Count; i++)
{
    for (int j = 0; j < list[i].Count; j++)
        Console.Write($"{list[i][j]} ");
        Console.WriteLine();
}