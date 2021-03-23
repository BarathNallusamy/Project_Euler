using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            


        }

        public static int MultiplesOfThreeAndFive(int x)
        {
            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                if (i% 3 == 0)
                {
                     sum += i;
                }
                else if(i%5==0)
                {
                    sum+=i;
                }
            }
            return sum;
        }

        

    }
}
