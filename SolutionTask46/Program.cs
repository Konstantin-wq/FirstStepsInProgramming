/*-----------------------------------------------------------------------------------------------------------------------
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
-------------------------------------------------------------------------------------------------------------------------
*/

//Объвляем глобальные переменные
double k_1 = 0;
double b_1 = 0;
double k_2 = 0;
double b_2 = 0;
double calcX = 0;
double calcY = 0;

//Считываем необходимые данные с консоли
void ReadIntegers() 
{
    Console.WriteLine("Введите коэффициенты для уравнения y = k1 * x + b1 :");
    
    Console.WriteLine("Введите коэффициент k1:");
    k_1 = double.Parse(Console.ReadLine() ?? "");
    
    Console.WriteLine("Введите коэффициент b1: ");
    b_1 = double.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Введите коэффициенты для уравнения y = k2 * x + b2 :");
    
    Console.WriteLine("Введите коэффициент k2:");
    k_2 = double.Parse(Console.ReadLine() ?? "");
    
    Console.WriteLine("Введите коэффициент b2:");
    b_2 = double.Parse(Console.ReadLine() ?? "");
    

}

//Рассчитываем координаты точки пересечения
void CalculateCoordOfPoint(double k1, double b1, double k2, double b2)
{

calcX = (b2-b1)/(k1-k2);

calcY = k1*calcX+b1;

}

//Выводим на экран координаты точки
void PrintCoordinateOfPoint(double numX , double numY )
{
Console.WriteLine("Коордтнаты точки пересечения: ");
Console.WriteLine("Координата X: " + calcX);
Console.WriteLine("Координата Y: " + calcY);
}

ReadIntegers();
CalculateCoordOfPoint(k_1, b_1, k_2, b_2);
PrintCoordinateOfPoint(calcX, calcY);










