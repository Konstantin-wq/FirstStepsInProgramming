/*------------------------------------------------------------------------------------
Задайте значение N. Программа, которая выведет все натуральные числа от 0 до N
--------------------------------------------------------------------------------------
*/

Console.Clear();

int ReadData()
{
    Console.WriteLine("Задайте число");
    return int.Parse(Console.ReadLine());
}





int NatauralNumbersPrinter(int num)
{
    if(num == 2) return 1;
    else
    {
        num--;
        Console.WriteLine(num);
        Console.Write(NatauralNumbersPrinter(num) + " ");
    }
    return num;
}

int inputNumber = ReadData();
NatauralNumbersPrinter(inputNumber+2);