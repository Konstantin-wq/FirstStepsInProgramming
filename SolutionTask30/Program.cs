//Программа, которая задает массив из 8 элементов и выводит их на экран
//*Ввод длинны массива и диапозон значений задается с клавиатуры

Console.WriteLine("Введите длину массива: ");
string? arrayLength = Console.ReadLine();

Console.WriteLine("Введите диапазон значений для массива:");

Console.WriteLine("Введите начальное значение: ");
string? arrayStart = Console.ReadLine();

Console.WriteLine("Введите конечное значение:");
string? arrayFinish = Console.ReadLine();

if(arrayLength!=null && arrayStart!=null && arrayFinish!=null)
{

    int lengthOfArray = int.Parse(arrayLength);
    int startOfArray = int.Parse(arrayStart);
    int finishOfArray = int.Parse(arrayFinish);
    System.Random numberSintezator = new Random();

//Заполняем массив
void FillingArray()
{
    int i = 0;
    Console.Write("[");
    while(i<lengthOfArray-1)
        {
        Console.Write(numberSintezator.Next(startOfArray,finishOfArray+1)+",");
        i++;
    }
    Console.Write(numberSintezator.Next(startOfArray,finishOfArray));
    Console.Write("]");
}
FillingArray();

}

