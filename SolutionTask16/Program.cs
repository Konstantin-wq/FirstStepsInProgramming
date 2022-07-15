// Программа, которая принимает на вход цифру обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
void CheckDayOfWeek ()
{
Console.WriteLine("Первый вариант решения задачи : ");
Console.WriteLine("Введите цифру от 1 до 7 :");
string? inputNumber = Console.ReadLine();
if (inputNumber != null)
{
    int dayNumber = int.Parse(inputNumber);
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
}


void CheckDayOfWeek2()
{
Console.WriteLine("Второй вариант решения задачи : ");
string [] daysOfWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

Console.WriteLine("Введите цифру от 1 до 7 :");
string? insertNumber = Console.ReadLine();
if (insertNumber != null)
{   
    int index = int.Parse(insertNumber);
    int arrayNumber = index -1;
    insertNumber  = daysOfWeek[arrayNumber];

    Console.WriteLine(daysOfWeek[arrayNumber]);
    if (daysOfWeek[arrayNumber] == daysOfWeek[5] || daysOfWeek[arrayNumber] == daysOfWeek[6])   
    {    
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }


} 


}


void CheckDayOfWeek3()
{
    Console.WriteLine("Третий вариант решения задачи : ");
	Console.WriteLine("Введите цифру от 1 до 7 :");
 string? inputNumber = Console.ReadLine();
 if (inputNumber != null)
 {
     int keyDay = int.Parse(inputNumber);

Dictionary<int,bool>daysOfWeek = new Dictionary <int,bool>()
{
{1, true},
{2, true},
{3, true},
{4, true},
{5, true},
{6, false},
{7, false}
};
if (daysOfWeek.ContainsKey(keyDay))
{   bool Value = daysOfWeek.GetValueOrDefault(keyDay);
    if (Value ==  false)
    {
       Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}   
else
{
    Console.WriteLine("Элемент не найден");
} 


 }
}


CheckDayOfWeek();

CheckDayOfWeek2();

CheckDayOfWeek3();