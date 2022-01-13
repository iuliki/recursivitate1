using System;
using System.Collections.Generic;
using System.Text;

namespace recursivitate1
{
    public static class recursiv
    {
        public static void AfisareVector(int[] array, int n)
        {
            if (n == 1)
                Console.WriteLine(array[n-1]); 
            else
            {
                
                AfisareVector(array, n - 1);
              Console.WriteLine(array[n-1]);

            }
        }
    }
}
