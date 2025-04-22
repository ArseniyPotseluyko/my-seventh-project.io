using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод текста с клавиатуры
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Текст не должен быть пустым.");
            }

            List<int> spacePositions = new List<int>();

            // Поиск позиций пробелов
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spacePositions.Add(i);
                }
            }

            // Вывод результатов
            if (spacePositions.Count > 0)
            {
                Console.WriteLine("\nПробелы находятся на следующих позициях:");
                Console.WriteLine(string.Join(", ", spacePositions));
            }
            else
            {
                Console.WriteLine("\nПробелы в тексте отсутствуют.");
            }
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
