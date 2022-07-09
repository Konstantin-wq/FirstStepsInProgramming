//Программа, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
string? inputA = Console.ReadLine(); 
string? inputB = Console.ReadLine(); 

if (inputA !=null && inputB !=null)
{
     int inputNumberOne = int.Parse(inputA); 
     int inputNumberTwo = int.Parse(inputB); 
if(inputNumberOne > inputNumberTwo)
{
    Console.WriteLine("Первое число " + inputNumberOne + " больше второго числа "+inputNumberTwo);
    Console.WriteLine("Максимальное число " + inputNumberOne);
}
else
{
    Console.WriteLine("Первое число " + inputNumberOne + " меньше второго числа "+inputNumberTwo);
    Console.WriteLine("Максимальное число " + inputNumberTwo);
}
}
