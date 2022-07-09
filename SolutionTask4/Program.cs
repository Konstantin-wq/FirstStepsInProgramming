// Программа, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int outputNumber = inputNumber%10;
    
    
    Console.WriteLine(outputNumber);
}