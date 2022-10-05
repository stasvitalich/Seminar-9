// Задача 64.
// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// Пример: 
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

try
{
    Console.WriteLine("Введите натуральное число больше 1:");
    int initialNumber = int.Parse(Console.ReadLine());

    ///Метод вывода натуральных чисел от N до 1:
    void NumberCounter(int initialNumber)
    {
        if (initialNumber < 0)
        {
            Console.Write($"{initialNumber} не является натуральным числом");
            return;
        }
        if (initialNumber == 0) return;
        if (initialNumber > 1)
        {
            Console.Write($"{initialNumber}, ");
        }
        else
        {
            Console.Write($"{initialNumber}");
        }
        NumberCounter(initialNumber - 1);
    }
    NumberCounter(initialNumber);
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: вы не ввели натурльное число. Попробуйте снова. Error: {ex.Message}");
}
