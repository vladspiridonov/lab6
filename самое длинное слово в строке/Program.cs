using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace самое_длинное_слово_в_строке
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            int max = 0;
            string word = "";
            foreach (string s in strArray)
            {
                if (s.Length >= max)
                {

                    if (s.Length == max)
                    {
                        max = s.Length;
                        word += " and " + s;
                    }
                    else
                    {
                        max = s.Length;
                        word = s;
                    }
                }
                
            }
            Console.WriteLine(word);
            Console.ReadKey();
                }
    }
}
