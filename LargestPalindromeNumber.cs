using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class LargestPalindromeNumber
    {
        public static int LargestPalindromeNumberWithThreeDigits(int x)
        {
            List<int> listNum = new List<int>();
            int sum = 0;
            int i = x;
            for (; i > 0; i--)
            {
                sum = x * i;
                if (IsPalindrome(sum))
                {
                    listNum.Add(sum);
                }
            }
            return listNum.Max();

        }

        public static bool IsPalindrome(int n)
        {
            bool results;
            int reverse, sum = 0, temp;
            temp = n;
            while (n >0)
            {
                reverse = n % 10;
                sum = (sum * 10) + reverse;
                n = n / 10;
            }
            results = (temp == sum) ? true: false;
            return results;
        }
    }
}
