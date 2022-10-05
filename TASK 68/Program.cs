// Задача 68.
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
try
{
    int m = GetNumbers("Введите m: ");
    int n = GetNumbers("Введите n: ");

    int akkermanFunction = Ack(m, n);

    Console.Write($"A(m, n) = {akkermanFunction} ");

    int Ack(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return Ack(m - 1, 1);
        else return Ack(m - 1, Ack(m, n - 1));
    }

    int GetNumbers(string input)
    {
        Console.Write(input);
        int output = int.Parse(Console.ReadLine());
        return output;
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: вы не ввели натурльное число. Попробуйте снова. Error: {ex.Message}");
}
