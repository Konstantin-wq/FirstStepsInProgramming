/*--------------------------------------------------------------------------
Программа, которая принимает на вход 3 числа, и проверяет может ли 
существовать треугольник с таким сторонами
----------------------------------------------------------------------------
*/


int sideA = 0;
int sideB = 0;
int sideC = 0;

ReadSides();
bool res = TestTriangle(sideA, sideB, sideC);
PrintAnswer(res);


//Метод чтения данных
void ReadSides()
{
    Console.Write("Введите число 1: ");
    sideA = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите число 1: ");
    sideB = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите число 1: ");
    sideC = int.Parse(Console.ReadLine() ?? "");

}


//Метод вычисления
bool TestTriangle(int num1, int num2, int num3)
{
    bool answer = ((sideA + sideB > sideC)
    && (sideB + sideC > sideA)
    && (sideA + sideC > sideB)) ? true : false;  

    return answer;
}


//Метод печати результата
void PrintAnswer(bool answer)
{
   
    if (answer)
    {
        Console.WriteLine("Из этих отрезков можно составить треугольник");
    }
    else
    {
        Console.WriteLine("Из этих отрезков нельзя составить треугольник");
    }
}







