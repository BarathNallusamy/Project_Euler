using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 5;
            List<int> listNum = new List<int>();
            int sum = 0;
            int i = x;
            for (; i > 0; i--)
            {
                for (; x > 0; x--)
                {
                    sum = x * i;
                    if (IsPalindrome(sum))
                    {
                        listNum.Add(sum);
                    }
                }
            }
            Console.WriteLine(listNum.Max());


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

        public static bool IsPalindrome(int n)
        {
            bool results;
            int reverse, sum = 0, temp;
            temp = n;
            while (n > 0)
            {
                reverse = n % 10;
                sum = (sum * 10) + reverse;
                n = n / 10;
            }
            results = temp == sum ? true : false;
            return results;
        }




    }
}
