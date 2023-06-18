/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8" */

Main();

void Main()
{
    int numM = Prompt("Введите число M: ");
    int numN = Prompt("Введите число N: ");
    WriteAllNumBetween(numM, numN);
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void WriteAllNumBetween(int userNumM, int userNumN)
{
    int currentNum = userNumM;
    if (currentNum <= userNumN)
    {
        Console.Write($"{currentNum} ");
        currentNum++;
        WriteAllNumBetween(currentNum, userNumN);
    }
}