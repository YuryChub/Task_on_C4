// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
string? n = Console.ReadLine();
int Num = 0, Sum = 0; 
for (int i = 0; i <= n.Length - 1; i++)
{
    Num = Convert.ToInt32(int.Parse(n[i].ToString()));
    Sum = Sum + Num;
}
Console.WriteLine($"Cумма цифр в числе: {Sum}");