using System;
using rearrange_array__1_elements.problems.Sorting;
namespace rearrange_array__1_elements
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] arr = new int[] { 62,43,54,16,84,27,93,75,377,120};
            QuickSelect alg = new QuickSelect(arr,3);
            int result = alg.FindIndex( 0, arr.Length-1);
            Console.WriteLine("result is {0}", result);
        }
    }
}
