using System;
using System.Text;

namespace task_2
{
    class Program
    {
        static void Main()
        {
            // Встановлення кодування консолі на UTF-8
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // Задання рядку
            Console.WriteLine("Задайте рядок:");
            string s = Console.ReadLine();

            // Великий цикл виконання необхідного завдання, який дає нову можливість задання літери при її відсутності в рядку
            while (true)
            {
                // Задання літери з перевіркою на правильність виконання цієї дії
                char letter;
                while (true)
                {
                    Console.Write("Задайте лiтеру, щоб порахувати кiлькiсть її входжень в заданому Вами рядку: ");
                    string input = Console.ReadLine();

                    if (input.Length == 1 && char.IsLetter(input[0]))    // "IsLetter" - перевірка, чи є заданий символ літерою
                    {
                        letter = input[0];
                        break;
                    }
                    else if (input.Length == 0)
                    {
                        Console.WriteLine("Помилка! Ви не ввели жодної лiтери.");
                    }
                    else
                    {
                        Console.WriteLine("Помилка! Надайте будь ласка одну лiтеру.");
                    }
                }

                string result = "";
                bool found_letter = false;

                // Виділення всіх входжень літери
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == letter)
                    {
                        result += $"Лiтера '{letter}' знайдена на позицiї {i}\n";
                        found_letter = true;
                    }
                }

                // Перевірка, чи була знайдена літера
                if (!found_letter)
                {
                    Console.WriteLine($"Лiтера '{letter}' не знайдена в заданому рядку. Спробуйте ще раз.");
                }
                else
                {
                    // Виведення результату
                    Console.WriteLine(result);
                    break;
                }
            }
        }
    }
}
