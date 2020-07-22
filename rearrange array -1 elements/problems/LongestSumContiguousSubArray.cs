using System;
namespace rearrange_array__1_elements.problems
{
    // Given an Array of positive and negative integers,
    // find a contiguous subarray whose sum (sum of elements) is maximum.

    public class LongestSumContiguousSubArray
    {
        int[] input = new int[] { 1, -2, 3, 4, -4, 6, -4, 3, 2 };

        public int MaxSum()
        {
            int max = 0, current = 0;
            for (int count = 0; count < input.Length; count++)
            {
                current = current + input[count];
                if (current < 0)
                {
                    current = 0;
                }

                if (max < current)
                {
                    max = current;
                }
            }

            return max;
        }
    }
}
