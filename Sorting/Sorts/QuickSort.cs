using System;

namespace Sorting.Sorts
{
    public class QuickSort
    {
        readonly int[] _nums;

        public QuickSort(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
                throw new Exception("Cannot initialise with a null or empty array");
            _nums = nums;
        }

        public int[] Sort()
        {
            PerformQuickSort(0, _nums.Length - 1);
            return _nums;
        }
        //Best case O(nlogn), worst case O(n*n)
        void PerformQuickSort(int low, int high)
        {
            if (low < high)
            {
                var index = GetPartitionIndex(low, high);
                PerformQuickSort(low, index - 1);
                PerformQuickSort(index + 1, high);
            }
        }
        //O(n)
        public int GetKSmallestElement(int k)
        {
            if (k > _nums.Length || k < 0)
                throw new Exception("Invalid index for K");
            return GetKIndexItem(0, _nums.Length - 1, k - 1);
        }
        
        int GetKIndexItem(int low, int high, int kIndex)
        {
            var index = GetPartitionIndex(low, high);
            if (index == kIndex)
                return _nums[index];
            else
            {
                if (index > kIndex)
                    return GetKIndexItem(low, index - 1, kIndex);
                else
                    return GetKIndexItem(index + 1, high, kIndex);
            }
        }

        int GetPartitionIndex(int l, int h)
        {
            var pivot = _nums[l];
            var i = l + 1;
            var j = h;

            while (i < j)
            {
                while (i <= h && _nums[i] <= pivot)//Keep going if elem is smaller than pivot elem
                    i++;
                while (j >= l && _nums[j] > pivot)//Keep going if elem is greater than pivot elem
                    j--;
                if (i < j)
                    Swap(i, j);
            }
            Swap(l, j);//Swap pivot to position j.
            return j;
        }

        void Swap(int a, int b)
        {
            var temp = _nums[a];
            _nums[a] = _nums[b];
            _nums[b] = temp;
        }
    }
}
