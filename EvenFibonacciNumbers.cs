using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class EvenFibonacciNumbers
    {

        public static (int number, int eventotal) HighestNumberOfFibonacciSeries(int x)
        {
            int a = 1;
            int b = 2;
            int c = 0;
            int sum = 0, num = 0;
            //int results = 4000000;

            for (int i = 0; i < x - 2; i++)
            {
                c = a + b;
                a = b;
                b = c;
                if (a % 2 == 0)
                {
                    sum += a;
                }
            }
            return (num, sum);
        }
    }
}
