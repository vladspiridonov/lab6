using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace удалить_текст_в_скобках
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            
            int N=0;
            int j = 0;
            int at=0;
            int count;
            //int end;
            //StringBuilder S = new StringBuilder(Console.ReadLine());
            // Массив индексов {
            while ((j <= str.Length) && (at > -1))
            {
                count = str.Length - j;
                j = str.IndexOf("{", j, count);
                if (j == -1) break;
                at = j;
                j++;
                N++;
            }
            j = 0;
            Console.WriteLine(N);
            int[] index1Array= new int[N];

            for (int i = 0; i < str.Length; i++,j++)
            {
                count = str.Length - i;
                i = str.IndexOf("{", i, count);
                if (i == -1) break;
                index1Array[j]=i;                
            }
            j = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(index1Array[i]);
            }
            //массив индексов }
            int M = 0;
            while ((j <= str.Length) && (at > -1))
            {
                count = str.Length - j;
                j = str.IndexOf("}", j, count);
                if (j == -1) break;
                at = j;
                j++;
                M++;
            }
            j = 0;
            Console.WriteLine(M);
            int[] index2Array = new int[M];
            for (int i = 0; i < str.Length; i++, j++)
            {
                count = str.Length - i;
                i = str.IndexOf("}", i, count);
                if (i == -1) break;
                index2Array[j] = i;
            }
            j = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(index2Array[i]);
            }
            string str2 = str;            
            for (int i = 0; i < N; i++)
            {
                int a = index1Array[i];
                int b = index2Array[j];
                while (b<a&&j<M)
                {
                    j++;
                }
                b = index2Array[j];
                //int c = b - a;
                str2 = str2.Remove(a+1, b-a-1);
                i = j;        
            }
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
