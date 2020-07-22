using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleteElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (isPrime(a[i]))
                {
                    Console.Write(a[i] + " ");
                }
            }

            Console.ReadKey();
        }
        public static bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
    }
}
