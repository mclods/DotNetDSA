using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/minimum-equal-sum-of-two-arrays-after-replacing-zeros/description/
namespace DotNetDSA.Leetcode
{
    internal class MinEqualArraySumReplacingZeroes
    {
        public long MinSum(int[] nums1, int[] nums2)
        {
            long nums1ZeroesCount = 0, nums2ZeroesCount = 0, nums1Sum = 0, nums2Sum = 0;
            
            for(int i=0; i<nums1.Length; ++i)
            {
                if (nums1[i] == 0)
                {
                    ++nums1ZeroesCount;
                }
                nums1Sum += nums1[i];
            }

            for (int i = 0; i < nums2.Length; ++i)
            {
                if (nums2[i] == 0)
                {
                    nums2ZeroesCount++;
                }
                nums2Sum += nums2[i];
            }

            long nums1MaxSum = nums1Sum + nums1ZeroesCount, nums2MaxSum = nums2Sum + nums2ZeroesCount;

            if (nums1MaxSum > nums2MaxSum && nums2ZeroesCount != 0)
            {
                return nums1MaxSum;
            }
            else if (nums2MaxSum > nums1MaxSum && nums1ZeroesCount != 0)
            {
                return nums2MaxSum;
            }
            else if (nums1MaxSum == nums2MaxSum)
            {
                return nums1MaxSum;
            }
            else
            {
                return -1;
            }
        }

        public static void Solution()
        {
            string[] nums1Inputs = Console.ReadLine()?.Split(" ") ?? [];
            string[] nums2Inputs = Console.ReadLine()?.Split(" ") ?? [];

            int[] nums1 = new int[nums1Inputs.Length];
            int[] nums2 = new int[nums2Inputs.Length];

            for(int i=0; i<nums1Inputs.Length; ++i)
            {
                nums1[i] = Convert.ToInt32(nums1Inputs[i]);
            }

            for(int i=0; i<nums2Inputs.Length; ++i)
            {
                nums2[i] = Convert.ToInt32(nums2Inputs[i]);
            }

            long output = new MinEqualArraySumReplacingZeroes().MinSum(nums1, nums2);
            Console.WriteLine(output);
        }
    }
}
