using System;

namespace rearrange_array__1_elements.problems.Sorting
{
    public class QuickSelect
    {
        private readonly int[] _arr;
        private int _index;
        
        public QuickSelect(int[] input, int index)
        {
            _arr = input;
            _index = index;
        }

        public int FindIndex(int lower, int upper)
        {

            if (upper <= lower)
            {
                return -1; 
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
            
            if (_index < upper)
            {
                FindIndex(start, upper-1); // sort left half
            }

            if (_index > upper)
            {
                FindIndex( upper+1, stop); // sort right half
            }

            if (_index == upper)
            {
                return _arr[_index-1];
            }

            return _arr[_index-1];
        }

        private void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}