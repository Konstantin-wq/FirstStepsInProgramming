//Программа, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа

//Метод решения задачи вариант 1
void variant1(System.Random numberSintezator)
{
    int number = numberSintezator.Next(10, 100);

    Console.WriteLine(number);
    //Вариант 1
    int firstNumber = number / 10;
    int secondNumber = number % 10;

    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.WriteLine(secondNumber);
    }

}

//Метод решения задачи вариант2
void variant2()
{
    //Вариант 2
    int numberKirilla = new Random().Next(10, 100);

    Console.Write("The random number is ");
    Console.WriteLine(numberKirilla);

    string stringNum = numberKirilla.ToString();

    Console.Write("The bigger digit is : ");
    if (stringNum[0] > stringNum[1])
    {
        Console.WriteLine(stringNum[0]);
    }
    else
    {
        Console.WriteLine(stringNum[1]);
    }

}

//Метод решения задачи вариант 3
void variant3(System.Random numberSintezator)
{
    

    char[] digits = numberSintezator.Next(10, 100).ToString().ToCharArray();

    Console.WriteLine(digits);

    int firstNumber = ((int)digits[0]) - 48;
    int secondNumber = ((int)digits[1]) - 48;

    int resultnumber = firstNumber > secondNumber ? resultnumber = firstNumber : resultnumber = secondNumber;
    Console.WriteLine(resultnumber);
}


System.Random numberSintezator = new Random();

variant1(numberSintezator);

variant2();

variant3(numberSintezator);
