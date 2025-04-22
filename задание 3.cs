using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод предложения с клавиатуры
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Предложение не должно быть пустым.");
            }

            // Разделение предложения на слова
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length < 3)
            {
                throw new ArgumentException("Предложение должно содержать минимум три слова.");
            }

            Console.WriteLine("\nИсходное предложение: " + input);

            // 1. Поменять местами первое и последнее слова
            string temp = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = temp;
            Console.WriteLine("Поменяны местами первое и последнее слова: " + string.Join(" ", words));

            // 2. Склеить второе и третье слова
            string concatenatedWords = words.Length >= 3 ? words[1] + words[2] : "Недостаточно слов для склеивания";
            Console.WriteLine("Склеенное второе и третье слова: " + concatenatedWords);

            // 3. Вывести третье слово в обратном порядке
            string reversedThirdWord = words.Length >= 3 ? new string(words[2].Reverse().ToArray()) : "Нет третьего слова";
            Console.WriteLine("Третье слово в обратном порядке: " + reversedThirdWord);

            // 4. В первом слове вырезать первые две буквы
            string modifiedFirstWord = words[0].Length > 2 ? words[0].Substring(2) : "Первое слово слишком короткое";
            Console.WriteLine("Первое слово без первых двух букв: " + modifiedFirstWord);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}
