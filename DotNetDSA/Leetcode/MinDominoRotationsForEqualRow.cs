using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/minimum-domino-rotations-for-equal-row/description
namespace DotNetDSA.Leetcode
{
    internal class MinDominoRotationsForEqualRow
    {
        public int MinDominoRotations(int[] tops, int[] bottoms)
        {
            int n = tops.Length;
            if (n == 0 || n == 1)
            {
                return 0;
            }

            int[] topFrequencies = new int[6];
            int[] bottomFrequencies = new int[6];

            // Find frequencies of all faces and store it
            for(int i=0; i<n; ++i)
            {
                topFrequencies[tops[i] - 1]++;
                bottomFrequencies[bottoms[i] - 1]++;
            }

            int minSwaps = -1;
            for(int i=0; i<6; ++i)
            {
                /* If a face can be swapped and arranged to make all faces on top or bottom as same,
                 * then it's sum of top and bottom frequency should be >= n.
                 * 
                 * If for a face the sum of top and bottom frequency > n then that face only has
                 * the possibility to be arranged.
                 * 
                 * If for a face the sum of top and bottom frequency == n then either that face
                 * can be arranged or some other one (for which sum of frequency == n) but the 
                 * point to noted here is that the min swaps needed to arrange either of them
                 * would be same. This optimizes our code further.
                 */
                if (topFrequencies[i] + bottomFrequencies[i] >= n)
                {
                    // Check if the face occur in each index either at top or at bottom
                    bool isPossible = true;
                    for(int j=0; j<n; ++j)
                    {
                        if (tops[j] != i+1 && bottoms[j] != i+1)
                        {
                            isPossible = false;
                            break;
                        }
                    }

                    int minNeededSwaps = n - Math.Max(topFrequencies[i], bottomFrequencies[i]);
                    if(isPossible)
                    {
                        minSwaps = minNeededSwaps;
                        break;
                    }
                }
            }

            return minSwaps;
        }

        public static void Solution()
        {
            string[] topInputs = Console.ReadLine()?.Split(" ") ?? [];
            string[] bottomInputs = Console.ReadLine()?.Split(" ") ?? [];

            int n = topInputs.Length;
            int[] tops = new int[n];
            int[] bottoms = new int[n];

            for (int i = 0; i < n; i++)
            {
                tops[i] = Convert.ToInt32(topInputs[i]);
                bottoms[i] = Convert.ToInt32(bottomInputs[i]);
            }

            int output = new MinDominoRotationsForEqualRow().MinDominoRotations(tops, bottoms);
            Console.WriteLine(output);
        }
    }
}
