// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int n = 2;
int [,,]array = new int [n,n,n];
List<int>numList = new List<int>();

int num =0;
for (int i=0;i<n;i++){
    for (int j=0;j<n;j++){
        for (int k=0;k<n;k++){
            num = new Random().Next(11,99);
            while (numList.Contains(num))
            {
                num = new Random().Next(11,99);
            }
            numList.Add(num);
            array[i,j,k] = num;
            Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}