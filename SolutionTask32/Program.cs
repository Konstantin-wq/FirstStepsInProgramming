/*---------------------------------------------------------------------------------------------
Задать массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. Найти сумму отрицательных
и положительных элементов массива.
-----------------------------------------------------------------------------------------------
*/

int positiveSum = 0;
int negativeSum = 0;
//Метод возвращает массив заполненный случайными числами от -9 до 9
int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;

    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();

    //Цикл заполнения массива
    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(-9, 10);
        i++;
    }
    return outArray;

}

//Метод подсчета
void CalculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            positiveSum++;
        }
        else
        {
            negativeSum++;
        }
        i++;

    }


}

//Выводим результат на консоль
void PrintResult()
{
    Console.WriteLine(positiveSum);
    Console.WriteLine(negativeSum);
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    int i = 0;
    while(i<inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

void VariantNaive()
{
    int[] bufferArray = FillingArray();
    PrintIntArray(bufferArray);
    CalculateTask(bufferArray);
    PrintResult();
}


VariantNaive();