/*------------------------------------------------------------------------------------
Сформируйте трехмерный массив из неповторящихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента
---------------------------------------------------------------------------------------
*/

// Метод заполнения трехмерного массива неповторяющимися двузначными значениями
int[,,] FillThreeDimArray(int countRow, int countColumn, int countThirdGrade)

{
    List<int> numbers = new List<int>(89);
    int num = 0;
    System.Random numberSynteztor = new System.Random();

    int i = 0; int j = 0; int k = 0;

    int[,,] outArray = new int[countRow, countColumn, countThirdGrade];

    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            k = 0;
            while (k < countThirdGrade)
            {
                num = numberSynteztor.Next(10, 100);
                if (numbers.Contains(num))
                {
                    num = numberSynteztor.Next(10, 100);
                }
                else
                {
                    numbers.Add(num);

                }
                outArray[i,j,k] = num;
                k++;
            }

            j++;
        }
        i++;
    }

    return outArray;
}


//Вывод трехмерного массива на экран с индексами элементов
void PrintThreeDimArray(int[,,] inputArray)
{
    int i = 0; int j = 0; int k = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            k = 0;
            while (k < inputArray.GetLength(2))
            {
                Console.Write(inputArray[i, j, k] + " " + "{" + i + "}" + "{" + j + "}" + "{" + k + "}" + "\t ");
                k++;
            }
            j++;
        }
        Console.WriteLine();
        i++;

    }

}



int[,,] threeGradeArray = FillThreeDimArray(3, 3, 3);
PrintThreeDimArray(threeGradeArray);






