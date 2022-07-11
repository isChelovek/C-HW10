// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

using System;
using static System.Console;
using hw10;

Clear();

Write("m = ");
int m = int.Parse(ReadLine());
Write("n = ");
int n = int.Parse(ReadLine());
WriteLine();
int[,] mainArray = Class1.GetRandomArray(m, n, -100, 100);
Class1.printArray(mainArray);
WriteLine();
mainArray = dellRowColume(mainArray, findMinID(mainArray));
Class1.printArray(mainArray);

int[] findMinID (int[,] array)
{
    int min     = mainArray[0,0];
    int[] minID = {0,0};
    for (int i = 0; i < mainArray.GetLength(0); i++)
    {
        for (int j = 0; j < mainArray.GetLength(1); j++)
        {
            if (min > mainArray[i,j]) 
            {
                min      = mainArray[i,j];
                minID[0] = i;
                minID[1] = j;
            }
        }
    }
    return minID;
}
int[,] dellRowColume(int[,] array, int[] minMax)
{
    int[,] tempArra = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int tempI = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
  
        if (minMax[0] != i)
        {
            int tempJ = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {

                if (minMax[1] != j)
                {        
                    tempArra[i - tempI, j - tempJ] = array[i,j];
                }
                else
                {
                    tempJ = 1;
                }
            }
        }
        else
        {
            tempI = 1;
        }
    }
    return tempArra;
}
