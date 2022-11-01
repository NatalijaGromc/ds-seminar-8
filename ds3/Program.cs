// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int n = 3;
int [,] createMatrix(){
    int [,] matrix = new int [n,n];
    for (int i=0;i<n;i++){
        for (int j=0;j<n;j++){
            matrix[i,j] = new Random().Next(10);
        }
    }
    return matrix;
}

int [,] multiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int [,] prodMatrix = new int [n,n];
    int sum = 0;
    for (int i=0;i<n;i++){
        for (int j=0;j<n;j++){
            sum = 0;
            for (int k=0;k<n;k++){
                sum += matrix1[i,k] * matrix2[k,j];
            }
            prodMatrix[i,j] = sum;

        }
    }
    return prodMatrix;
}

void printMatrix( int[,] matrix){
for (int i=0;i<n;i++){
        for (int j=0;j<n;j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }    
    
}
int [,] matrix1 = createMatrix();
int [,] matrix2 = createMatrix();
int [,] matrixProd = multiplyMatrices(matrix1,matrix2);
Console.WriteLine("Матрица 1");
printMatrix(matrix1);
Console.WriteLine("Матрица 2");
printMatrix(matrix2);
Console.WriteLine("Перемножение матрицы 1 на матрицу 2");
printMatrix(matrixProd);