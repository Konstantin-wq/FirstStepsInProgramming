//Программа , которая которая принимает на вход число и выдаёт количество цифр в числе.

Console.Clear();
Console.Write("Введите число: ");

string inputLineNumber = Console.ReadLine() ?? "";
int inputNumber = int.Parse(inputLineNumber);

DateTime timePoint = DateTime.Now;

//1 вариант
int VariantChar() //метод возвращает значение тип int
{
    // int numberLength = 0;

    // char[] array = inputLineNumber.ToCharArray();
    // numberLength = array.Length;

    // return numberLength;
    //Замена блока кода одной строкой
    return inputLineNumber.ToCharArray().Length;
}

//2 вариант
int VariantSimple()
{
    int numberLength = 0;
    int digits = 1;
    while (digits < inputNumber)
    {
        digits = digits * 10;
        numberLength++;

    }
    return numberLength;
}

//3 вариант с логарифмом
int VariantLog10()
{
    return (int)Math.Log10(inputNumber)+1;
}


int result = 0;

timePoint = DateTime.Now; // проверяем скорость работы различных вариантов исполнения программы
result = VariantChar();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = VariantSimple();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = VariantLog10();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);


