// Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.
using System;
using static System.Console;


Clear();


Write("Введите число строк: ");
int numberLines = int.Parse(ReadLine());
if (numberLines !=0 )
{
    pintTrianglePack(numberLines);
}
else
{
    WriteLine("Маловато будет");
}
void pintTrianglePack(int maxRow)
{
    string doubleTab = "\t\t";
    int maxCol = 2;

    printTab(maxRow);
    WriteLine("1");
    if (maxRow == 1) return;
    printTab(maxRow - 1);
    Write("1");
    Write(doubleTab);
    Write("1");
    WriteLine();
    if (maxRow == 2) return;
    for (int numRow = 2; numRow < maxRow; numRow++)
    {
        printTab(maxRow - numRow);
        Write("1");
        Write(doubleTab);
        for (int numCol = 1; numCol < maxCol; numCol++)
        {
            Write(getCkn(numRow, numCol));
            Write(doubleTab);
        }
        maxCol++;
        Write("1");
        WriteLine();
    }
}

void printTab(int n)
{
    for (int i = 0; i < n; i++)
    {
        Write("\t");
    }
}

int getCkn(int n, int k)
{
    return Factorial(n) / (Factorial(k) * (Factorial(n - k)));
}

int Factorial (int num)
{
    if (num == 1) return 1;

    return num * Factorial(num - 1);
}