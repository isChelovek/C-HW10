// Доп. Даны две строки. Определить можно ли из символов первой строки, собрать вторую. 
// Допускается любое количество пробелов. Регистр символов различный в любой последовательности.
// Пример:
// Строка 1. Tom Marvolo Riddle
// Строка 2. I am Lord Voldemort
// Ответ: Да
// Строка 1. Tom Marvolo Riddle
// Строка 2. Lord Voldemort
// Ответ: Нет - остались свободные символы.

using System;
using static System.Console;
using hw10;

Clear();

Write("Введите первою строчку: ");
string firstRow  = ReadLine();
Write("Введите вторую строчку: ");
string secondRow = ReadLine();

string firstRowNoSeparete  = dellSpacer(firstRow);  // Удаляем пробелы из строк
string secondRowNoSeparete = dellSpacer(secondRow); // Удаляем пробелы из строк

firstRowNoSeparete.ToLower();  // Приводим все к одному регистру
secondRowNoSeparete.ToLower(); // Приводим все к одному регистру

WriteLine (chekRow(firstRowNoSeparete, secondRowNoSeparete) ? "Ответ: Да" : "Ответ: Нет - остались свободные символы.");

bool chekRow(string firstRow, string secondRow)
{
  bool resut = true;
  int[] numersUseSymbols = new int[secondRow.Length];     // Создаем массив с результатами поиска "-1" -элемент не найден
  for (int i = 0; i < numersUseSymbols.GetLength(0); i++) // Инициализируем массив "-1" -элемент не найден
  {
    numersUseSymbols[i] = -1;
  } 
  int countSybols = 0;

  for (int i = 0; i < secondRow.Length; i++)
  {
    if (secondRow[i] != ' ')
    {
      int countTry = 0;
      do
      {
        if (findSymbole(firstRow, secondRow[i], countTry))
        {
          if (!findNum(numersUseSymbols, countTry))
          {
            numersUseSymbols[countSybols] = countTry;
            countSybols++;
          }
        }
        countTry++;
      }
      while (secondRow.Length > countTry);
    }
  }

  for (int i = 0; i < numersUseSymbols.GetLength(0); i++)
  {
    if (numersUseSymbols[i] == -1) return false;
  }
  return true;
}


bool findSymbole(string str,  char findIt, int startFind)
{
  for (int i = startFind; i < str.Length; i++)
  {
    if (str[i] == findIt) return true; 
  }
  return false;
}

bool findNum(int[] array,  int findIt)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == findIt) return true; 
  }
  return false;
}

string dellSpacer (string str)
{
  string resulrStr = "";
  for (int i = 0; i < str.Length; i++)
  {
    if (str[i] != ' ') 
    {
      resulrStr += str[i];
    }
  }
  return resulrStr;
}