// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число N:");
int nam = Convert.ToInt32(Console.ReadLine());
int nam3 = nam3 = nam / 100;
int nam2 = (nam - (nam3 *100)) / 10;
Console.WriteLine(nam2);


// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267912 -> 6

Console.Write("Введите число N:");
int nam = Convert.ToInt32(Console.ReadLine());
int nam1 = 10;
int nam2 = 0;
int nam3 = 0;
int ten = 10;
for (int I = 1; nam1 > 9; I++ )
{
     nam1 = nam / ten;
     nam2 = nam % ten;
     ten = ten * 10;
}
if (ten >= 1000)
    {
    ten = ten / 100;
    nam3 = nam2 % ten;
    nam2 = nam2 / ten;
    nam3 = nam3 / (ten / 10);
    Console.WriteLine(nam3);
    }
else
    {
        Console.Write("Третьей цифры нет");
    }
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня в неделе N:");
int day = Convert.ToInt32(Console.ReadLine());
string day1 = "не существует";
if ( day > 0 && day < 8 )
{
    if ( day == 6 || day == 7 ) day1 = "Выходной";
    else day1 = "Рабочий день";
}
Console.WriteLine(day1);
