namespace hw10;
using static System.Console;

public class Class1
{
    public static int[] GetRandomArray(int size)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(100);
        }
        return result;
    }

    public static int[,] GetRandomArray(int row, int column)
    {
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(100);
        }
    }
      return result;
    }
    
    ///<summary>
    ///Metod2
    ///<summary>
    public static int[] GetRandomArray(int size, int minValue, int maxValue)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(minValue, maxValue+1);
        }
        return result;
    }
   public static int[,] GetRandomArray(int row, int column, int minValue, int maxValue)
    {
    int[,] result = new int[row, column];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue+1);
            }
        }
    return result;
    }
    public static double[,] GetRandomArray(int row, int column, int minValue, int maxValue, int numberOfecimal)
    {
    double divider = numberOfecimal != 0 ? numberOfecimal * 10 : 1;
    double[,] result = new double[row, column];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = (new Random().Next(minValue, maxValue+1)) / divider;
            }
        }
    return result;
    }
    ///<summary>
    ///Metod3
    ///<summary>
    public static int[] GetArrayFromString(string arrayStr)
    {
        string[] arS=arrayStr.Split(new String [] {" ", ",", ", "},StringSplitOptions.RemoveEmptyEntries);
        int[] result=new int[arS.Length];
        for(int i=0; i < arS.Length; i++)
        {
            result[i]=int.Parse(arS[i]);
        }
        return result;
    }

    public static void printArray(int[] array) // Печать массива
    {
        Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Write(array[i]);
            Write(i < array.Length-1 ? ", " : "");
        }
        Write("]");
    }
    public static void printArray(double[] array) // Печать массива
    {
      //  Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Write($"{array[i]:f1} \t");
           // Write(i < array.Length-1 ? ", " : "");
        }
     //   Write("]");
    }


    public static void printArray(int[,] array) // Печать двумерного массива массива
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Write($"{array[i, j]} \t ");
            }
            WriteLine();
        }
    }
   public static void printArray(string[,] array) // Печать двумерного массива массива
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Write($"{array[i, j]} \t ");
            }
            WriteLine();
        }
    }

    public static void printArray(double[,] array) // Печать двумерного массива массива
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Write($"{array[i, j]} \t ");
            }
            WriteLine();
        }
    }

    public static string arrayToString (int[] array) // Печать массива
    {
        string str = "";
        str+="[";
        for (int i = 0; i < array.Length; i++)
        {
             str+=(array[i]);
             str+=(i < array.Length-1 ? ", " : "");
        }
         str+=("]");
     return str;
    }
}
