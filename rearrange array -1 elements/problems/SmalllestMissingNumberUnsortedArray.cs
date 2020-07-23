using System;
using System.Threading;

namespace rearrange_array__1_elements.problems
{
    public class SmalllestMissingNumberUnsortedArray
    {
        public static void Find()
        {
            int[] arr = new int[] { 8, 5, 6, 1, 9, 11, 2, 7, 4, 0 };
            int size = arr.Length;
            int smallest = 0;

            for (int i = 0; i < size; i++)
            {
                bool found = false;
                smallest = i;
                for (int j = 0; j < size; j++)
                {
                    if (arr[j] == smallest)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    break;
                }
            }
            Console.WriteLine("smallest missing number is {0} ", smallest);
        }
    }
}