using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Ввод текста с клавиатуры
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Текст не должен быть пустым.");
            }

            int digitCount = 0;
            int nonDigitCount = 0;

            // Анализ символов в строке
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    nonDigitCount++;
                }
            }

            // Вывод результатов
            Console.WriteLine($"\nКоличество цифр в тексте: {digitCount}");
            Console.WriteLine($"Количество символов, не являющихся цифрами: {nonDigitCount}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
