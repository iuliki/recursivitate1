using System;

namespace recursivitate1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = { 1, 34, 3, 78, 5, 6, 7, 8 };
            int n;
            AfisareVector(array, n);
           
        }
        static int AfisareVector(int[] array,int  n)
        {
            if (n == 1)
                Console.WriteLine(array[n]);
            else
                return AfisareVector(array, n - 1);
        }
    }
}
