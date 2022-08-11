/*------------------------------------------------------------------------------------
Не используя рекурсию вывести первые N чисел Фибоначчи
--------------------------------------------------------------------------------------
*/

//Первые два числа Фибоначчи 0 и 1
//Fn -1 + Fn-2 = Fn

Console.Write("Введите количество чисел в ряде Фибоначчи:");
int decemalNumber = ReadDecemalNumber();
string outLine = Fibonnaci(decemalNumber);
PrintAnswer(outLine);

int ReadDecemalNumber()
{
    return int.Parse(Console.ReadLine()?? "");
}

string Fibonnaci(int n)
{
string answer = "";

if (n ==2)
{
    answer = "0 1";
}
else if (n == 1)
{
    answer = "0";
}
else
{
    answer = "0 1";
    int fn_1 = 1;
    int fn_2 = 0;
    int fn;
    for (int i = 0; i<n -2; i++)
    {
        fn = fn_1 + fn_2;
        answer+= " " + fn;
        fn_2 = fn_1;
        fn_1 = fn;
    }

}
return(answer);
}


void PrintAnswer(string answer)
{
Console.WriteLine("Ряд Фибоначчи для заданного количества чисел: " + answer);
}


