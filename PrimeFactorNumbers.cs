using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class PrimeFactorNumbers
    {

        public static long LargestPrimeFactor(long number)
        {
            List<long> listNum = new List<long>();
            long temp = 1;
            for (long i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    temp = number/ i;
                    listNum.Add(i);
                    i = 1;
                    number = temp;
                }
            }
            return listNum.Max();
        }

    }
}
