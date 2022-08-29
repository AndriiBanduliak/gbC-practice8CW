/*Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя

using static System.Console;
Clear();

int colums = Convert.ToInt32(ReadLine());
int rows = Convert.ToInt32(ReadLine());

int[,]  Arra = GetMatrixArray(rows, colums, 10, 20);

if(colums == rows)
{
PrintMatrixArray(Arra);
//NewMatrix(Arra);
//WriteLine();
//PrintMatrixArray(Arra);
}

else WriteLine("It's a boolshit");



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
       for (int i = 0; i < matt.GetLength(0); i++)
       {
           
        for (int j = 0; j < matt.GetLength(1); j++)
        {   
         
                        
            int temp = matt[1, j];
            matt[1, j] = matt[ i, 1]; 
            matt[matt.GetLength(0)-1 , j] = temp;
            
            
        }    
     }
}
*/
using static System.Console;
Clear();

int[,] arr = GetMatrixArray(5, 5, 10, 99);

if (arr.GetLength(0) != arr.GetLength(1))
{
    WriteLine("It's a boolshit"); return;
}
PrintMatrixArray(arr);
arr = arrSwap(arr);



WriteLine();
PrintMatrixArray(arr);
int[,] GetMatrixArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
       
    }
}
int[,] arrSwap(int[,]arr)
{
    int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[j,i] = arr[i,j];
        }
    }
    return result;
}