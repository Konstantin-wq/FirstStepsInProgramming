//Программа, которая принимает на вход 2 числа, и проверяет, является ли первое число квадратом второго
string? inputLkneOne = Console.ReadLine(); 
string? inputLkneTwo = Console.ReadLine(); 
if(inputLkneOne != null && inputLkneTwo != null)
{
        int inputNumberOne = int.Parse(inputLkneOne); 
        int inputNumberTwo = int.Parse(inputLkneTwo);  
if(inputNumberOne == inputNumberTwo * inputNumberTwo)
{
    Console.WriteLine("yes"); 
}
else
{
    Console.WriteLine("no");
}
} 


