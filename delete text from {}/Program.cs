using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delete_text_from___
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = str;
            int a = 0;
            int a1 = 0;
            int b = 0;
            int count;
            int end=str.Length;
            int start;
            int E=end;
            //StringBuilder S = new StringBuilder(Console.ReadLine());
            // Массив индексов {
            do
            {
                E = end;
                for (start = 0; start < end; start++)
                {
                    count = end - start;
                    a = str2.IndexOf("{", start, count);
                    if (a == -1) break;
                    start = a + 1;
                    count = end - start;
                    b = str2.IndexOf("}", start, count);
                    if (b == -1) break;
                    a1 = str2.IndexOf("{", start, count);
                    if (a1 < b && a1 != -1)
                    {
                        start = a1;
                        continue;
                    }
                    if (b - a > 1)
                        str2 = str2.Remove(a + 1, b - a - 1);
                    start = a + 1;
                    end = str2.Length;
                }
            } while (E!=end);                     
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
