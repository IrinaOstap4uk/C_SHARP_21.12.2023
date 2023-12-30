// 3. Напиши программу, которая принимает 
//   на вход целое число из отрезка [10, 99] и показывает
//   наибольшую цифру числа.

Console.Write("Введите целое двухзначное число");
int A = int.Parse(Console.ReadLine()!);

if (A >= 10 && A <= 99)    
    int num1 = A / 10;
    int num2 = A % 10;

else if (num1 >= num2)
    Console.WriteLine(num1);

else
    Console.WriteLine(num2);