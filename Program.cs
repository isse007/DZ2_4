// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.


// int a = 459;
// int a1 = a / 100;
// int a2 = a / 10 % 10;
// int a3 = a % 10;
// System.Console.WriteLine($"{a1},{a2},{a3}");


void FirstDivSecond(int a)
{
    int a1 = a / 100;
    int a2 = a / 10 % 10;
    int a3 = a % 10;
    System.Console.WriteLine($"{a1},{a2},{a3}");
}
System.Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

FirstDivSecond(n);