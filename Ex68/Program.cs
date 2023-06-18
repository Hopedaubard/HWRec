/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/
Main();

void Main()
{
    int numM = Prompt("Введите положительное число M: ");
    int numN = Prompt("Введите положительное число N: ");
    if (numM > 0 && numN > 0)
    {
        Console.WriteLine($"Результат вычесления функции Аккермана: {AkkermanFunction(numM, numN)}");
    }
    else Console.WriteLine("Одно или оба числа являются отриательными!");
}

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) //m = 0
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0)) // m > 0, n = 0
    {
        return AkkermanFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0)) // m > 0, n > 0
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
    else
        return n + 1;
}