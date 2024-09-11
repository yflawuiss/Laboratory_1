using System;

namespace example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Dfg+t5-r7y;asd*s34;rt";
                int t = s.IndexOf(";");
                int i, k = 0;
                for (i = 0; i <= t; i++)
                {
                    if (char.IsLetter(s[i])) k++;
                }
                Console.WriteLine(k);
                Console.ReadKey();
        }
    }  
}
