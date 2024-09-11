using System;
using System.Text;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Встановлення кодування консолі на UTF-8
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string sent;
            string[] words;

            // Великий цикл з урахуванням к-сті слів та можливості провести операцію перестановки 
            while (true)
            {
                // Задання речення
                Console.WriteLine("Задайте речення для перестановки першого та останнього слiв мiж собою:");
                sent = Console.ReadLine();

                // Розбиття рядку на окремі слова
                words = sent.Split(' ');

                // Перевірка на кількість слів
                if (words.Length < 2)
                {
                    Console.WriteLine("Помилка! Речення повинно бути не меньше двох слiв. Спробуйте ще раз.\n");
                }
                else
                {
                    break;
                }
            }

            // Заміна між собою першого та останнього слів
            if (words.Length > 1)  // Якщо слів мінімум 2 для можливості перестановки 1-го та останнього слів між собою
            {
                string temp = words[0]; // Перше слово 
                words[0] = words[words.Length - 1]; // Перше слово дорівнюється останньому
                words[words.Length - 1] = temp; // Останнє слово дорівнюється першому
            }

            // Формування нового речення
            Console.WriteLine("Отримане нове речення:");
            string new_sent = string.Join(" ", words);
            Console.WriteLine(new_sent);
        }
    }
}
