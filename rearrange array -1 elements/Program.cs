using System;
using rearrange_array__1_elements.problems.Sorting;
namespace rearrange_array__1_elements
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] arr = new int[] { 6,4,5,1,8,2,9,7,3,10};
            QuickSort alg = new QuickSort(arr);
            alg.Sort( 0, arr.Length-1);
            alg.PrintResult();
        }
    }
}
