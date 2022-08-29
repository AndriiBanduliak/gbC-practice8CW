/*Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том,
 сколько раз встречается элемент входных данных.*/


using static System.Console;
using System.Linq;
Clear();
WriteLine("Enter array parameters: ");
int[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
int[,] array=GetMatrix(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(array);
WriteLine();
int[] rowArray=GetRowArray(array);//.OrderBy(x=>x).ToArray();
SortArray(rowArray);
WriteLine(String.Join(" ",rowArray));
PrintData(rowArray);



int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int k = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[k] = inArray[i, j];
            k++;
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int temp = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = temp;
            }
        }
    }
}

void PrintMatrix(int[,] inArray)
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

void PrintData(int[] inArray)
{
    int el=inArray[0];
    int count=1;

    for (int i = 1; i < inArray.Length; i++)
    {
        if(el!=inArray[i])
        {
            WriteLine($"{el}-->{count};");
            el=inArray[i];
            count=1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{el}-->{count};");
}