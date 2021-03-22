using System;

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

        public static int LargestPalindromeNumber(int x)
        {
            
            int a = 9, b = 9;
            int sum = 0, reverse = 0;

            for (int i = 9; i > 0; i--)
            {
                sum = a * b;

                while (sum > 0)
                {
                    int remainder = sum % 10;
                    reverse = (reverse * 10) + remainder;
                    sum = sum / 10;
                }

            }
            Console.WriteLine(sum + "" + reverse);
            return reverse;


        }
    }
}
