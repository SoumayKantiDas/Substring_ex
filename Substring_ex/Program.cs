using System;

namespace Substring_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hellow world";
            string s1 = "orange";
            string s2 = "red";
            s1 += s2;
            Console.WriteLine(s1);
            s1 = s1.Substring(2, 5);
            Console.WriteLine(s1);

        }
    }
}
