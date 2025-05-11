using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/build-array-from-permutation/description/
namespace DotNetDSA.Leetcode
{
    internal class BuildArrayPermutation
    {
        public int[] BuildArray(int[] nums)
        {
            int[] outputArr = new int[nums.Length];
            for(int i=0; i<nums.Length; ++i)
            {
                outputArr[i] = nums[nums[i]];
            }

            return outputArr;
        }

        public static void Solution()
        {
            string[] inputArr = Console.ReadLine()?.Split(" ") ?? [];
            int[] numArr = new int[inputArr.Length];

            for(int i=0; i<inputArr.Length; ++i)
            {
                numArr[i] = Convert.ToInt32(inputArr[i]);
            }

            int[] output = new BuildArrayPermutation().BuildArray(numArr);
            foreach(int i in output)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
