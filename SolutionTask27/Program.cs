//Программа, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

System.Random numberSintezator = new Random();

void VariantNaive()
{
    int i = 0;
    Console.Write("[");
    while(i<8-1) //Строка 9 и строка 14 - убирают лишнюю запятую в конце
    {
        Console.Write(numberSintezator.Next(0,2)+",");
        i++;
    }
    Console.Write(numberSintezator.Next(0,2));
    Console.Write("]");
}

VariantNaive();