using System;

namespace rearrange_array__1_elements
{
    using System;

    //    Problem: Given array of size N, containing elements from 0 to N-1.
    //    All values from 0 to N-1 are present in array and if they are not there than -1 is there to take its place.
    //    Arrange values of array so that value i is stored at arr[i].
    //    Input: [8, -1, 6, 1, 9, 3, 2, 7, 4, -1]
    //    Output: [-1, 1, 2, 3, 4, -1, 6, 7, 8, 9]

    public class Program
    {
        public int[] Convert(int[] input)
        {
            for (int count = 0; count < input.Length; count++)
            {
                int num = input[count];
                int countingIndex = num;
                bool somethingChanged = false;

                if (countingIndex < 0) { continue; }

                while (input[countingIndex] != countingIndex)
                {
                    int nextIndex = input[countingIndex];
                    input[countingIndex] = countingIndex;
                    if (nextIndex < 0) { break; }
                    countingIndex = nextIndex;
                    somethingChanged = true;
                }

                if (somethingChanged)
                {
                    if (input[count] == num)
                    {
                        input[count] = -1;
                    }
                }
            }

            return input;
        }

        public static void Main()
        {
            int[] arr1 = new int[] { 8, -1, 6, 1, 9, 3, 2, 7, 4, 1 };
            int[] arr2 = new int[] { -1, 1, 2, 3, 4, -1, 6, 7, 8, 9 };
            Program prog = new Program();
            int[] output = prog.Convert(arr1);
            foreach (var item in output)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}