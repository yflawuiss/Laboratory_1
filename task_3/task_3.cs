using System;
using System.Text;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Встановлення кодування консолі на UTF-8
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // Задання речення
            Console.WriteLine("Задайте речення:"); string sent = Console.ReadLine();

            // Розбиття рядку на окремі слова
            string[] words = sent.Split(' ');

            // Цикл виявлення слів з парними номерами
            Console.WriteLine("\nОтримані слова з речення, які мають парний номер:");
            for (int i = 1; i < words.Length; i += 2) // початок з індексу 1, під яким є слово з парним номером  
                                                     // і < words.Length - убереження від виводу останнього слова з речення, де непарна кількість слів
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}