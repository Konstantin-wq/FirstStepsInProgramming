//Программа, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число: ");
string? inputLineN = Console.ReadLine();

//Метод возведения в степень "3" числа N
void degreeN()
{
if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    string lineN =  "";
    string lineNN = string.Empty;
    int s = 1;

    while (s <= numberN)
    {
        lineN = lineN + s + " ";
        lineNN = lineNN +(s*s*s).ToString() + " ";
        s++;
    

    }       
    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
 

}
}


degreeN();

