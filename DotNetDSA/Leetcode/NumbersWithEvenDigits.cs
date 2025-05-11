using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/find-numbers-with-even-number-of-digits/description/
namespace DotNetDSA.Leetcode
{
    internal class NumbersWithEvenDigits
    {
        public int FindNumbers(int[] numArr)
        {
            int evenDigitNumCount = 0;
            foreach(int i in numArr)
            {
                if(i >= 10 && i <= 99)
                {
                    ++evenDigitNumCount;
                }
                else if(i >= 1000 && i <= 9999)
                {
                    ++evenDigitNumCount;
                }
                else if(i >= 100000 && i<= 999999)
                {
                    ++evenDigitNumCount;
                }
            }

            return evenDigitNumCount;
        }

        public static void Solution()
        {
            string[] inputArr = Console.ReadLine()?.Split(" ") ?? [];
            int[] numArr = new int[inputArr.Length];

            for(int i=0; i<inputArr.Length; ++i)
            {
                numArr[i] = Convert.ToInt32(inputArr[i]);
            }

            int output = new NumbersWithEvenDigits().FindNumbers(numArr);
            Console.WriteLine(output);
        }
    }
}
