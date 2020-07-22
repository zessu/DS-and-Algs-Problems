using System;
using rearrange_array__1_elements.problems;
namespace rearrange_array__1_elements
{
    using System;

    public class Program
    {
        public static void Main()
        {
            LargestSumContiguousSubArray prog = new LargestSumContiguousSubArray();
            int[] output = prog.Convert();
            foreach (var item in output)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
