/*-----------------------------------------------------------------------
Программа, которая преобразовывает десятичное число в двоичное
-------------------------------------------------------------------------
*/

//Решение в одну строку
Console.WriteLine(Convert.ToString(int.Parse(Console.ReadLine()),2));

//Расписываем решение

int number = int.Parse(Console.ReadLine());
string outLine = Convert.ToString(number,8); //конвертация в восьмеричную систему исчесления через метод ToString
Console.WriteLine(outLine);