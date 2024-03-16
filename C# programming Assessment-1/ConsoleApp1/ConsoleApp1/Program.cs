using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Random rnd = new Random();
            for (int j = 0; j < a.Length; j++)
            {
                int d = rnd.Next(100, 999);
                a[j] = d;
            }
            foreach (int j in a)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();

            int[] b = new int[] { 10, 23, 17, 12, 6, 9, 11, 19 };
            int count = 0;
            for (int j = 1; j < b.Length; j++)
            {
                if (isPrime(System.Math.Abs(b[j] - b[j - 1])))
                {
                    Console.WriteLine($"{b[j - 1]},{b[j]} ");
                    count++;
                }
            }
            Console.WriteLine($"Number of such pairs is: {count}");

            int i = 0;
            if (b[0] < b[1]) Console.Write(b[0] + " ");
            for (i = 1; i < b.Length; i++)
            {
                if (b[i] >= b[i - 1] || b[i] < b[i+1])
                {
                    Console.Write(b[i]+" ");
                }
                else
                {
                    Console.WriteLine();
                }

            }
            Console.WriteLine() ;
        }
        public static bool isPrime(int a)
        {
            if (a == 2) return true;
            int c = a / 2;
            for (int i = 2; i < c; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
    }
}
