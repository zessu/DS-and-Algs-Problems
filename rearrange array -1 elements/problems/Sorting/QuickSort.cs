using System;

namespace rearrange_array__1_elements.problems.Sorting
{
    // recursive alg
    // partition array so that we have elements smaller than pivot to the left and greater to the right
    // sort those subsections recursively
    // o Select pivot as first element in the array.
    // o Use two index variable lower and upper.
    // o Set lower index as second element in the array and upper index as last element of the array.
    // o Increase lower index till value at lower index is higher than pivot.
    // o Then decrement upper index till the value at upper index is lower than pivot.
    // o Then swap the value at lower and upper index.
    // o Repeat the above 3 steps till upper index is greater than lower
    // index.
    // o In the end, swap value at pivot and upper index.
    public class QuickSort
    {
        private readonly int[] _arr;
        
        public QuickSort(int[] input)
        {
            _arr = input;
        }

        public void Sort(int lower, int upper)
        {

            if (upper <= lower)
            {
                return; 
            }
            int size = _arr.Length;
            int pivot = lower;
            int start = lower;
            int stop = upper;

            while (lower < upper)
            {
                while (_arr[lower] <= _arr[pivot] && lower<upper)
                {
                    lower++;
                }
                
                while (_arr[upper] > _arr[pivot] && lower<=upper)
                {
                    upper--;
                }
                
                if (lower < upper)
                {
                    Swap(_arr, lower, upper);
                }
            }
            Swap(_arr, pivot, upper);
            Sort(start, upper-1); // sort left half
            Sort( upper+1, stop); // sort right half
        }

        private void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
        
        public void PrintResult()
        {
            foreach (int item in _arr)
            {
                Console.WriteLine("{0} ", item);
            }
        }
    }
}