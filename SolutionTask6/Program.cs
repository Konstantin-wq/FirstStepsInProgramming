// Программа, которая принимает на вход три числа, и выдает максимальное из этих чисел
string? inputA = Console.ReadLine(); 
string? inputB = Console.ReadLine(); 
string? inputС = Console.ReadLine(); 

if (inputA !=null && inputB !=null && inputС !=null)
{
     int inputNumberOne = int.Parse(inputA); 
     int inputNumberTwo = int.Parse(inputB); 
     int inputNumberThree = int.Parse(inputС);

if(inputNumberOne > inputNumberTwo && inputNumberOne > inputNumberThree)
{
    Console.WriteLine("Максимальное число " + inputNumberOne);
}
if(inputNumberTwo > inputNumberOne && inputNumberTwo > inputNumberThree)
{
    Console.WriteLine("Максимальное число " + inputNumberTwo);
}
if(inputNumberThree > inputNumberOne && inputNumberThree > inputNumberTwo)
{
    Console.WriteLine("Максимальное число " + inputNumberThree);
}
}







