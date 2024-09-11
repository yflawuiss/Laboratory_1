using System;

namespace example_2
{
    class Program
    { 
        static void Main(string[] args)
        {
            string s = "АУАУАПАУК";
            int i = 0;
            do
            {
                string ss = s.Substring(i, 2);
                if (ss == "АУ")
                {
                    s = s.Insert(i, "O"); i = i + 3;
                }
                else
                {
                    i++;
                }
            }
            while (i < s.Length - 1);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}