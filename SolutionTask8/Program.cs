//Программа, которая на вход принимает число N, а на выходе показывает все чётные числа от 1 до N
string? inputA = Console.ReadLine(); 

if (inputA !=null)
{
     int inputNumberOne = int.Parse(inputA);
     
     int numberB = 2;
     
     string lineOutput = "";

     while (inputNumberOne > numberB)
     {
        lineOutput = lineOutput + numberB +",";
        numberB = numberB + 2;
     }
     Console.WriteLine(lineOutput);
}