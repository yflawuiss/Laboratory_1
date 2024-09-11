using System;
using System.Text;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Встановлення кодування консолі на UTF-8
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Задайте рядок:"); // Введення тексту
            string s = Console.ReadLine();
            int count = 0;

            foreach (char c in s) // Перебирання кожного символу "с" рядка "s" 
            {
                if (c == 'A' || c == 'А') // Враховуємо латинську літеру А та кирилицю
                {
                    count++; 
                }
            }

            // Цикл з перевірки наявності літер "А"
            if (count > 0)
            {
                Console.WriteLine($"Кiлькiсть лiтер 'А' в рядку: {count}");
            }
            else
            {
                Console.WriteLine("У заданому рядку немає лiтер 'А'.");
            }

            Console.ReadKey();
        }
    }
}
