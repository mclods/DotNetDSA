using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDSA.Leetcode
{
    internal class MinOpsToMakeArrayIncreasing
    {
        public int MinOperations(int[] inputs)
        {
            int minOps = 0;

            /* min number of operations needed to make any element input[i] > input[i-1]
             * is input[i-1] - input[i] + 1  */
            for (int i = 1; i < inputs.Length; i++)
            {
                if (inputs[i - 1] >= inputs[i])
                {
                    minOps += inputs[i - 1] - inputs[i] + 1;
                    inputs[i] += inputs[i - 1] - inputs[i] + 1;
                }
            }

            return minOps;
        }

        public static void Solution()
        {
            string[] inputStrings = Console.ReadLine()?.Split(" ") ?? [];

            int[] inputs = new int[inputStrings.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = Convert.ToInt32(inputStrings[i]);
            }

            int output = new MinOpsToMakeArrayIncreasing().MinOperations(inputs);
            Console.WriteLine(output);
        }
    }
}
