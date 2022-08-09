/*------------------------------------------------------------------------
Программа, которая находит сумму элементов, стоящих на нечентных позициях
Найти все пары в массиве и вывести пользователю 
--------------------------------------------------------------------------
*/

Console.Clear();

//Заполняем массив
int[] FillingArray()

{
    int[] outArray = new int[10];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 10)
    {
        outArray[i] = numberSintezator.Next(1, 20);
        i++;
    }
    return outArray;

}

//Поиск суммы элементов в нечетных позициях в массиве (по индексу)
int CalculateTask(int[] inputArray)
{
    int sumOfElems = 0;
    int i = 1;
    while (i < inputArray.Length)
    {
        sumOfElems = inputArray[i] + sumOfElems;
        i += 2;
    }

    return (sumOfElems);
}


//Выводим массив
void PrintIntArray(int[] inputArray)
{
    int i = 0;
    while (i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

//Поиск всех парных элементов в  (в случае обнаружения повторений , выводит значение повторяющегося элемента)
void PairOfElements(int[] inputArray)
{
    //Используем словарь
    Dictionary<int, int> douplicateNumbers = new Dictionary<int, int>();
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (douplicateNumbers.ContainsKey(inputArray[i]) == false)
        {
            douplicateNumbers[inputArray[i]] = 1;
            continue;
        }
        if (douplicateNumbers[inputArray[i]] == 1)
        {
            douplicateNumbers[inputArray[i]]++;
            Console.WriteLine("Число " + inputArray[i] + " повторяется");
        }

    }
}

//Вывод на экран заполненнного массива
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);

//Вывод результата сложения элементов расположенных на нечетных позициях
int result = CalculateTask(bufferArray);
Console.Write("Сумма элементов расположенных на нечетных индексах: ");
Console.WriteLine(result);

//Вывод повторяющихся элементов
PairOfElements(bufferArray);