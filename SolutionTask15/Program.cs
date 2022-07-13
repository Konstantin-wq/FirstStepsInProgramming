//Программа, которая выводит третью цифру заданного числа, или сообщает, что третьей цифры нет
Console.Clear();

void searchThirdNumber1()
{
Console.WriteLine("Введите Ваше число:");
string? inputNumber = Console.ReadLine();
char[] numbers = inputNumber.ToCharArray();
if (numbers.Length >=3)
{
    Console.WriteLine(numbers[2]);
}
else
{
    Console.WriteLine("Третьей цифры в числе нет!");
}
}




void searchThirdNumber2()
{

Console.WriteLine("Введите число: ");
string? inputNumber = Console.ReadLine();
if (inputNumber != null)
{
    int a = int.Parse(inputNumber);
    int numberCheck = a;
    int count = 0;
    if (a>100 && a<1000)
    {
        int newNumber = a;
        newNumber = a%10;
        Console.WriteLine("Третья цифра в заданном числе " + a + " это " + newNumber);
    }
    if (a<100)
    {
        Console.WriteLine("Третьей цифры в числе " + a +" нет!" );
    }
    if (a>=1000)
    {
        int checkNumber = a;
              
        
        while(checkNumber >=1000)
        {
            checkNumber = checkNumber/10;
            count ++;
        }
            checkNumber = checkNumber%10;
        Console.WriteLine("Третья цифра в заданном числе "+ a + " это " +checkNumber);
    
    }
}
}


searchThirdNumber1();

searchThirdNumber2();

