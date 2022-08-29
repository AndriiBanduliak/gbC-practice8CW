/*Задача 53: Задайте двумерный массив. Напишите программу,
 которая поменяет местами первую и последнюю строку массива.*/

using static System.Console;
Clear();

int[,]  Arra = GetMatrixArray(3, 4, 10, 20);

PrintMatrixArray(Arra);
NewMatrix(Arra);
WriteLine();
PrintMatrixArray(Arra);




int[,] GetMatrixArray(int rows,int colums, int minValue, int maxValue)


{
   int[,] result=new int[rows,colums];
   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < colums; j++)
        {
            result[i,j]=new Random().Next(minValue,maxValue+1);
        }
   }
   return result;
}

void PrintMatrixArray(int[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
          Write($"{inArray[i,j]} ");
      }
    WriteLine();
   }
}

void NewMatrix(int[,] matt)
{
       
        for (int j = 0; j < matt.GetLength(1); j++)
        {
            int temp = matt[0, j];
            matt[0, j] = matt[matt.GetLength(0)-1 , j]; //под вопросом
            matt[matt.GetLength(0)-1 , j] = temp;
        }    
    
}