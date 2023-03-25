// Задайте двумерный массив. Напишите программу,
//  которая упорядочит по возрастанию элементы 
//  каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] CreateArray(int y, int x)
{
  int[,] array = new int[y, x];
  return array;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] FillArrayRandom(int[,] coll)
{
  for (int i = 0; i < coll.GetLength(0); i++)
  {
    for (int j = 0; j < coll.GetLength(1); j++)
    {
      coll[i, j] = new Random().Next(20);
    }
  }
  return coll;
}

int[,] SortLines(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1) - 1; j++)
    {
      for (int k = 0; k < matr.GetLength(1) - 1; k++)
      {
        if (matr[i, k] > matr[i, k + 1])
        {
          (matr[i, k], matr[i, k + 1]) = (matr[i, k + 1], matr[i, k]);
        }
      }
    }
  }
  return matr;
}

int[,] matr = CreateArray(Prompt("Enter the number of lines: "), Prompt("Enter number of columns: "));
matr = FillArrayRandom(matr);
PrintArray(matr);
Console.WriteLine();
PrintArray(SortLines(matr));