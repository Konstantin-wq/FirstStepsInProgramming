/*-----------------------------------------------------------------------------------
  Программа, которая из имен через запятую выберет случайное имя и выведет в терминал
-------------------------------------------------------------------------------------*/

//Вариант случайного выбора из заданной строки
void ChoiceFromString()
{
string listOfNames = "Игорь, Антон,Сергей,Михаил,Алексей";
string[] charNames = listOfNames.Split(new char[] {','});

Random name = new Random();
Console.WriteLine(charNames[name.Next(0,4)]);
}

ChoiceFromString();

//Случайный выбор из имен, которые пользователь введет с консоли
void ChoiceFromConsole()
{
    Console.WriteLine("Введите имена для случайного выбора через запятую:");
    string? playersName = Console.ReadLine();
    if (playersName != null)
    {
    string[] players = playersName.Split(new char[] {','});

    Random name = new Random();
    
    Console.WriteLine(players[name.Next(0,players.Length)]);
    }

}

ChoiceFromConsole();