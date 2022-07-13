// // Программа, которая будет принимать на вход 2 числа т выводить, является ли второе число кратным первому. 
// //Если второе число не кратно первому - выводить остаток от деления.

// string? inputLkneOne = Console.ReadLine();
// string? inputLkneTwo = Console.ReadLine();

// if(inputLkneOne !=null && inputLkneTwo !=null)
// {
//     int inputNumberOne = int.Parse(inputLkneOne);
//     int inputNumberTWo = int.Parse(inputLkneTwo);
    
//     int div = inputNumberTWo%inputNumberOne;

//     if (div == 0)
//     {
//         Console.WriteLine("Yes");
//     }
//     else
//     {
//         Console.WriteLine(div);

//     }
// }

//Вариант 2

// Console.WriteLine("Enter first number: ");
// string? firstLine = Console.ReadLine();
// Console.Write("Enter second number");
// string? secondLine = Console.ReadLine();
// int first = int.Parse(firstLine);
// int second = int.Parse(secondLine);

// if(second%first == 0)
// {
//     Console.WriteLine("Кратное");
// }
// else
// {
//     Console.WriteLine("Не кратное, " + second%first);
// }

// Вариант 3

Console.WriteLine("Введите первое число : ");
string? firstNumber = Console.ReadLine();
Console.WriteLine("Введите второе число : ");
string? secondNumber = Console.ReadLine();

if(firstNumber != null && secondNumber != null)
{
    int firstOutNumber = int.Parse(firstNumber);
    int secondOutNumber = int.Parse(secondNumber);
    int c = secondOutNumber%firstOutNumber;
    string iext = "";

    if (c == 0)
    {
        iext = "Да, второе число кратно первому";
        Console.WriteLine(iext);
    }
    else
    {
        iext = "Нет,второе число не кратно первому, остаток : " + c;
        Console.WriteLine(iext);
    }


}
