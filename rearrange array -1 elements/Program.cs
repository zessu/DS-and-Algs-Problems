using System;
using rearrange_array__1_elements.problems;
namespace rearrange_array__1_elements
{
    using System;

    public class Program
    {
        public static void Main()
        {
            LongestSumContiguousSubArray prog = new LongestSumContiguousSubArray();
            int output = prog.MaxSum();
            Console.Write("{0} ", output);
        }
    }
}
