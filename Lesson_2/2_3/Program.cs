// 3. Напишите программу, которая будет принимать на вход два
//    числа и выводить, является ли второе число кратным первому.
//    Если второе число не кратное первому, то программа выводит 
//    остаток от деления.

Console.WriteLine("Введите первое число");
Console.WriteLine("Введите второе число");

int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);

if (n % m == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("НеКратно " + n % m);
}
