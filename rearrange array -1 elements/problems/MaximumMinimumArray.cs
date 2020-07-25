using System;
namespace rearrange_array__1_elements.problems
{
    //    Problem: Given a sorted array, rearrange it in maximum-minimum form.
    //    Input: [1, 2, 3, 4, 5, 6, 7]
    //    Output: [7, 1, 6, 2, 5, 3, 4]
    public class MaximumMinimumArray
    {
        public static void FindMinMaxArray()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7};
            int[] arr2 = new int[arr.Length];
            int end = arr.Length - 1;
            int elementIndex = 0;

            for (int count = 0; count < (arr.Length/2); count++)
            {
                    order(arr2, elementIndex, arr[count], arr[end]);
                    end--;
                    elementIndex += 2;
            }

            // odd number of elements, we missed one
            if (arr.Length % 2 != 0)
            {
                int missedIndex = ((arr.Length - 1)/2);
                arr2[arr2.Length-1] = arr[missedIndex];
            }
            
            foreach (var item in arr2)
            {
                Console.WriteLine("{0} ", item);
            }
        }

        public static void order(int[] arr, int elementIndex, int current, int next)
        {
            arr[elementIndex] = next;
            arr[elementIndex + 1] = current;
        }
    }
}
