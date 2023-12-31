// 2. Напишите программу, которая принимает
//    на вход координаты точки (X и Y), причем X и Y
//    не равны нулю и выдает номер координатной четверти
//    плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату оси абсцисс точки");
Console.WriteLine("Введите координату оси ординат точки");

int X = int.Parse(Console.ReadLine()!);
int Y = int.Parse(Console.ReadLine()!);

if (X > 0 && Y > 0)
    Console.Write("четверть 1");

else if (X < 0 && Y < 0)
    Console.Write("четверть 3");

else if (X < 0 && Y > 0)
    Console.Write("четверть 2");

else if (X > 0 && Y < 0)
    Console.Write("четверть 4");

else if (X == 0 && Y == 0)
     Console.Write("Начало координат");

else if (X > 0 || X < 0 && Y == 0)
     Console.Write("Точка лежит на оси абсцисс");

else if (X == 0 && Y < 0 || Y > 0)
     Console.Write("Точка лежит на оси ординат");










