// Задача 66.
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Пример: 
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

try
{
    int m = GetNumbers("Введите m: ");
    int n = GetNumbers("Введите n (должно быть больше m): ");
    int temp = m;

    if (m > n)
    {
        m = n;
        n = temp;
    }

    GetSumm(m, n, temp = 0);

    void GetSumm(int m, int n, int summ)
    {
        summ = summ + n;
        if (n <= m)
        {
            Console.Write($"Сумма элементов = {summ} ");
            return;
        }
        GetSumm(m, n - 1, summ);
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
