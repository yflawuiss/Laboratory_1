using System;

namespace example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "бiологiя алгебра iсторiя географiя геометрiя";
            //отримали масив слів
            string[] a;
            a = s1.Split(' ');
            //переставили елементи масиву
            //в зворотньому порядку
            Array.Reverse(a);
            //з'єднали елементи масиву в строку
            //роздільник пробіл
            string s2 = string.Join(" ", a);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}