/*
1) Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число");
int N= Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N; i++)
{
    Console.WriteLine(Math.Pow(i,3));
}

2) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координату Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);

Console.WriteLine(d);


3) Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int number1 = number/10000;
int number2 = (number/1000)%10;
int number4 = (number/10)%10;
int number5 = number%10;

if (number1==number5 && number2 == number4)
{
  Console.WriteLine($"Ваше число: {number} палиндром.");
}
else
{
  Console.WriteLine($"Ваше число: {number} не палиндром.");  
}
