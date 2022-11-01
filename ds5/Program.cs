// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int n = 8;
int [,]array2D = new int[n,n];
int[] numArray = new int[n*n];
int i_array=0;
int j_array=0;
int i_move=1;
int n_move = n;
int direction = 0; //0 вправо 1 вниз 2 влево 3 вверх
for (int i=0;i<numArray.Length;i++){

    array2D[i_array,j_array] = i+1;
    if(direction == 0) j_array++;
    if(direction == 1) i_array++;
    if(direction == 2) j_array--;
    if(direction == 3) i_array--;
    if (i_move==n_move-1) {
        if ((direction == 2) || (direction == 0)) n_move--;
        direction++;
        if (direction == 4) direction = 0;
        i_move = 0;
    }
    else i_move++;
    
}

for (int i=0;i<n;i++){
    for (int j=0;j<n;j++){
        Console.Write(String.Format("{0:00} ",array2D[i,j]));
    }
    Console.WriteLine();
}
