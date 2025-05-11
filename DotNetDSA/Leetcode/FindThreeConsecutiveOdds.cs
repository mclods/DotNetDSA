using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/three-consecutive-odds/description/
namespace DotNetDSA.Leetcode
{
    internal class FindThreeConsecutiveOdds
    {
        public bool ThreeConsecutiveOdds(int[] numsArr)
        {
            if(numsArr.Length < 3)
            {
                return false;
            }

            bool oddsExist = false;
            for(int i=1; i<numsArr.Length - 1; ++i)
            {
                if (numsArr[i] % 2 != 0 && numsArr[i-1] % 2 != 0 && numsArr[i+1] % 2 != 0)
                {
                    oddsExist = true;
                    break;
                }
            }

            return oddsExist;
        }

        public static void Solution()
        {
            string[] inputArr = Console.ReadLine()?.Split(" ") ?? [];
            int[] numsArr = new int[inputArr.Length];

            for(int i=0; i<inputArr.Length; ++i)
            {
                numsArr[i] = Convert.ToInt32(inputArr[i]);
            }

            bool output = new FindThreeConsecutiveOdds().ThreeConsecutiveOdds(numsArr);
            Console.WriteLine(output);
        }
    }
}
