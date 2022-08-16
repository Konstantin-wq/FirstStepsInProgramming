/*--------------------------------------------------------------------------------------
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

* Заполнить числами Фиббоначи и выделить цветом найденную цифру
----------------------------------------------------------------------------------------
*/


Console.Clear();
int inputNumberString = 0;
int inputNumberColumn = 0;

// Метод заполнения двумерного массива числами Фибоначчи
int[,] FillTwoDimArray(int countRow, int countColumn)

{
    int amountOfNumbers = countColumn * countRow;
    int[] fibonacciNumbers = new int[amountOfNumbers];

    if (amountOfNumbers == 2)
    {
        fibonacciNumbers[0] = 0;
        fibonacciNumbers[1] = 1;
    }
    else if (amountOfNumbers == 1)
    {
        fibonacciNumbers[0] = 0;
    }
    else
    {
        fibonacciNumbers[0] = 0;
        fibonacciNumbers[1] = 1;
        int s = 0;
        int f1 = 1;
        int f2 = 1;
        for (int k = 2; k < fibonacciNumbers.Length; k++)
        {

            s = f1 + f2;
            f1 = f2;
            f2 = s;
            fibonacciNumbers[k] = s;

        }

    }


    int i = 0; int j = 0;

    int[,] outArray = new int[countRow, countColumn];

    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = fibonacciNumbers[i * countRow + j];
            j++;
        }
        i++;
    }

    return outArray;
}


//Выводим массив на экран
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "\t");
            j++;
        }
        Console.WriteLine(); //альтернативный способ Console.WriteLine("\n");
        i++;

    }

}


//Читаем число с консоли
void ReadNumber(int[,] inputArray)
{

    Console.WriteLine("Введите позицию элемента столбце :");
    inputNumberString = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите позицию элемента в строке :");
    inputNumberColumn = int.Parse(Console.ReadLine() ?? "");





}


//Метод поиска введенного числа
void SearchNumber(int[,] inputArray)
{
    int[,] outArray = inputArray;//new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    try
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
                if (inputArray[i, j] == inputArray[inputNumberString, inputNumberColumn])
                {
                    Console.WriteLine("Число по заданным координатам есть в заданном массиве, его значение равно:  " + inputArray[inputNumberString, inputNumberColumn] + " Индекс элемента: [{0},{1}]", i, j);
                }
        }
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Введенный индекс в заданном массиве отсутствует");
        Console.ResetColor();
    }







}

//Выделяем найденный элемент цветом и выводим на экран
void ColouringNumber(int[,] inputArray)
{
    try
    {
        int i = 0; int j = 0;

        while (i < inputArray.GetLength(0))
        {
            j = 0;
            while (j < inputArray.GetLength(1))
            {
                if (inputArray[inputNumberString, inputNumberColumn] == inputArray[i, j])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(inputArray[i, j] + "\t");
                Console.ResetColor();
                j++;
            }
            Console.WriteLine(); //альтернативный способ Console.WriteLine("\n");
            i++;

        }
    }
    catch
    {
        
    }
}






int[,] twoDimArray = FillTwoDimArray(5, 5);
PrintTwoDimArray(twoDimArray);


ReadNumber(twoDimArray);
SearchNumber(twoDimArray);
ColouringNumber(twoDimArray);




