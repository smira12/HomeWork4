/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Вы ввели не число! Введите число.");
        }
    }
    return result;
}

int GetSummNumber(int number)
{
    int summ = 0;
    while (number > 0 || number < 0)
    {
        summ += number % 10;
        number = number / 10;
    }
    return summ;
}


int number = GetNumber("Введите число: ");
int sum = GetSummNumber(number);

Console.WriteLine($"Сумма цифр числа {number} -> {sum}");