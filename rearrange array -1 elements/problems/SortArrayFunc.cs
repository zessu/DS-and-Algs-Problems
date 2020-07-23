using System;
namespace rearrange_array__1_elements.problems
{
    public class SortArrayFunc
    {
        public static int[] Sort1toN()
        {
            int[] arr = new int[] { 8, 5, 6, 1, 9, 3, 2, 7, 4, 10 };
            int curr, value, next;
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                curr = i;
                value = -1;
                /* swaps to move elements in proper position.*/
                while (curr >= 0 && curr < size && arr[curr] != curr + 1)
                {
                    next = arr[curr];
                    arr[curr] = value;
                    value = next;
                    curr = next - 1;
                }
            }
            return arr;
        }
    }
}
