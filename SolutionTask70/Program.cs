/*----------------------------------------------------------------------------------------------
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
-------------------------------------------------------------------------------------------------
*/

int numberM = ReadData("Задайте число M:");
int numberN = ReadData("Задайте число N:");
//Читаем данные от пользователя
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}



//Функция Аккермана
int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return (AkkermanFunction(m, n));
}

int akkermanResult = AkkermanFunction(numberN, numberM);
Console.WriteLine("Результат вычисления: " + akkermanResult);

