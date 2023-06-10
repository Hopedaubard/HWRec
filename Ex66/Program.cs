/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Main();

void Main()
{
    int numM = Prompt("Введите положительное число M: ");
    int numN = Prompt("Введите положительное число N, которое больше M: ");
    if (numM <= numN && numM > 0 && numN > 0)
    {
        int sum = SumAllNumBetween(numM, numN, 0);
        Console.WriteLine($"Сумма чисел в промежутке от M до N: {sum}");
    }
    else { Console.WriteLine($"Условия не выполнены, попробуйте снова!"); Main(); }
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumAllNumBetween(int userNumM, int userNumN, int sumNum)
{
    int currentNum = userNumM;
    if (currentNum <= userNumN)
    {
        sumNum += currentNum;
        currentNum++;
        sumNum = SumAllNumBetween(currentNum, userNumN, sumNum);
    }
    return sumNum;
}