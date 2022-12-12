/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


Console.Write("Введите количество элементов массива: ");
int elements = int.Parse(Console.ReadLine() ?? "");

int[] myArray = new int[elements];

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    myArray[i] = int.Parse(Console.ReadLine() ?? "");
}
Console.Write($"Вывод массива: ");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i]);
    if (i < myArray.Length - 1)
        Console.Write(", ");
}
Console.WriteLine();
