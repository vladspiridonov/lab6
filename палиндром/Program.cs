using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace палиндром
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string str1 = "";
            string str2 = "";
            foreach (string s in strArray)
                str1 += s;
            str1=str1.ToLower();
            Console.WriteLine(str1);
            foreach (char c in str1)
                str2 = c + str2;
            Console.WriteLine(str2);
            if (str1==str2)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
