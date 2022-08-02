// Программа, которая принимает на вход число (A) и выдает сумму чисел от 1 до А
Console.Clear();
Console.Write("Введите число: ");

int inputNumber = int.Parse(Console.ReadLine());
int t;
//Вариант 1 (простой)

void VariantSimple()
{
    int sumOfNumbers = 0;
    for (int i = 1; i<=inputNumber; i++)
    {
        sumOfNumbers+= i; //sumOfNumbers = sumOfNumbers+i
 
    }
Console.WriteLine("Сумма чисел от 1 до "+inputNumber+ " = " + sumOfNumbers);
}


//Вариант 2 (используем формулу Гаусса) 

void VariantGauss()
{
    int sumOfNumbers =0;

    sumOfNumbers = ((1 + inputNumber)*inputNumber)/2;
   
    Console.WriteLine("Сумма чисел от 1 до "+inputNumber+ " = " + sumOfNumbers);
}

t = Environment.TickCount;
VariantSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
VariantGauss();
Console.WriteLine("Gauss time: {0} ms", Environment.TickCount - t);