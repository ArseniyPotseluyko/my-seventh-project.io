using System;

class Program
{
    // Метод для вычисления порядкового номера букв
    static int GetAlphabetPosition(char letter)
    {
        letter = char.ToLower(letter); // Приведение к нижнему регистру

        if (letter >= 'а' && letter <= 'я') // Проверка русских букв
            return letter - 'а' + 1;
        if (letter >= 'a' && letter <= 'z') // Проверка английских букв
            return letter - 'a' + 1;

        return 0; // Игнорирование неалфавитных символов
    }

    // Метод для вычисления цифрового корня числа (до одной цифры)
    static int GetDigitalRoot(int number)
    {
        while (number >= 10)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            number = sum;
        }
        return number;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите фамилию, имя и отчество: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Ошибка: текст не должен быть пустым!");
            }

            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length < 3)
            {
                throw new ArgumentException("Ошибка: необходимо ввести фамилию, имя и отчество!");
            }

            int totalSum = 0;

            foreach (string word in words)
            {
                int wordSum = 0;
                foreach (char letter in word)
                {
                    wordSum += GetAlphabetPosition(letter);
                }
                totalSum += wordSum;
            }

            int personalityCode = GetDigitalRoot(totalSum);

            Console.WriteLine($"Код личности: {personalityCode}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
