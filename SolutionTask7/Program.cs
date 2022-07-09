//Программа, которая на вход принимает число и выдает,является ли оно четным
string? inputA = Console.ReadLine(); 

if (inputA !=null)
{
     int inputNumberOne = int.Parse(inputA); 
     int div = inputNumberOne%2;
     if(div == 0)
     {
        Console.WriteLine("Число "+ inputNumberOne + " четное");
     }
    else
    {
        Console.WriteLine("Число "+ inputNumberOne + " нечетное");
    }
}   
