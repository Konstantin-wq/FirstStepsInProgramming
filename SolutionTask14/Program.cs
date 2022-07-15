//Программа, которая получает на вход трехзначное число, и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int a = int.Parse(inputNumber);
    int count = 0;
    int numberCheck = a;                
        while (numberCheck > 0)                 
        {
            numberCheck = numberCheck / 10;
            count++;
        }

if (count == 3)
    {
    int newNumberA = a % 100;
    int newNumberB = newNumberA / 10;
    Console.WriteLine("Вторая цифра заданного числа это " + newNumberB);
    }
else
    {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Число не подходит по разрядности. Разряд числа  " + count);
    }
}


