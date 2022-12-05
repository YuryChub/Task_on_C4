// Задача 29: Напишите программу, которая задаёт массив из 8 элементов,
// запрашивает данные(элементы массива) у пользователя 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int n = 8;
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", array)}]");