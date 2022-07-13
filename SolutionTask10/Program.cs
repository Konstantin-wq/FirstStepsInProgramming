// Программа, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

//Вариант 1

int number = new Random().Next(100,1000);
Console.WriteLine("Число:" + number);
int numberSecondDigit = number/100;
int numberThirdDigit = number%10;
Console.WriteLine("Число после удаления второй цифры: " + numberSecondDigit + numberThirdDigit);


//Вариант 2

void middleDigitCutter()
{
    int number = new Random().Next(100, 1000);
    Console.Write("The random number is : ");
    Console.WriteLine(number);
    string stringNum = number.ToString();
    Console.Write("The modified num is :");
    Console.Write(stringNum[0]);
    Console.WriteLine(stringNum[2]);

}
//Вариант 3

void middleDigitCutter2()
{
    int number = new Random().Next(100,1000);
    Console.Write("The Random number is : ");
    Console.WriteLine(number);

    int num1 = number/100;
    int num2 = number%10;

    Console.Write("The modified num is : ");
    Console.Write(num1*10 + num2);
}

middleDigitCutter();

middleDigitCutter2();
