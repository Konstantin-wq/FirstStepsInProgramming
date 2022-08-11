/*--------------------------------------------------------------------------------------------------------------------
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

----------------------------------------------------------------------------------------------------------------------
*/

Console.WriteLine("Введите количество чисел которые будем проверять: ");
int m = 0;
int[] arrayNumbers = new int[m];

//Вводим данные с консоли
int[] ReadNumber(int m)
{
    m = int.Parse(Console.ReadLine() ?? "");
    int[] ReadNumber = new int[m];
    int i = 0;
    
    while (i < m)
    {
        Console.WriteLine("Введите число " + (i+1));
        ReadNumber[i] = int.Parse(Console.ReadLine() ?? "");
        i++;

    }
    
    return ReadNumber;



}

//Находим числа, которые больше 0
int CalculateNumber(int[] arrayA)
{
    int count = 0;
    int i = 0;
    while (i < arrayA.Length)
    {
        if (arrayA[i] > 0)
        {
            count++;
            
        }
        i++;
    }
    
    return (count);
}

//Вывод на экран результатов
void PrintResult(int count)
{
    Console.WriteLine("Количество заданных положительных элементов: " + count);

}



int[] numbers = ReadNumber(m);
PrintResult(CalculateNumber(numbers));