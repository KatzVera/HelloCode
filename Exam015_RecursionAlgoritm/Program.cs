// таблица строк
string[,] table = new string[2, 5];
// String.Empty
// table[0, 0]  table[0, 1]  table[0, 2] ... table[0, 4]
// table[1, 0]  table[1, 1]  table[1, 2] ... table[1, 4]


/* table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for(int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/

// матрица с целыми числами

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // i < 3 тоже самое i < matrix.GetLenth(0) для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // matrix.GetLenth(1) т.к. для столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine(); // принудительный перехлд на новую строку
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // интервал [1, 10)
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);