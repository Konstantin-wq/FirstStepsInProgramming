//Программа, которая принимает на вход два числа (A и B) и возводит число А в натруальную степень B

Console.Clear();
Console.WriteLine("Введите число которе вы хотите возвести в степень: ");
string? firstNumber = Console.ReadLine();
Console.WriteLine("Введите степень в которую вы хотите возвести число: " + firstNumber);
string? secondNumber = Console.ReadLine();
if (firstNumber != null && secondNumber!= null)
{
int a = int.Parse(firstNumber);
int b = int.Parse(secondNumber);

//Решение задачи через цикл
void CycleVersion()
{
    
    int result = 1;
    for (int i = 1; i<=b; i++)
    {
        result = result*a;
         
        //Console.WriteLine(result);
    }
    Console.WriteLine(result);
}

//Второй вариант с калькулятором
void Calculator()
{
    Console.WriteLine("Введите действие которое вы хотите совершить с числами " + firstNumber + " и " + secondNumber);
    Console.WriteLine("Доступные действия : + - / * pow(для возведения в степень)");
    string? mathAction = Console.ReadLine();
    double resultCalc = 0;
    
    //Используем оператор выбора Switch
    switch(mathAction)
    {
        case "+":
        resultCalc =a+b;
        Console.WriteLine(resultCalc);
        break;
        
        case "-":
        resultCalc = a-b;
        Console.WriteLine(resultCalc);
        break;

        case "/":
        resultCalc =a/b;
        Console.WriteLine(resultCalc);
        break;
        
        case "*":
        resultCalc =a*b;
        Console.WriteLine(resultCalc);
        break;

        case "pow":
        resultCalc = Math.Pow(a,b);
        Console.WriteLine(resultCalc);
        break;

        default:
        Console.WriteLine("Операция не поддерживается программой");
        break;
    }


}
    


CycleVersion();

Calculator();
}