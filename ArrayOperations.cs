using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayClassWork
{
        class ArrayOperations
    {
        public int SumArray(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }

        public int FindMax(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        public int[] ReverseArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - 1 - i];
            }
            return reversed;
        }

        public (int even, int odd) CountEvenOdd(int[] arr)
        {
            int even = 0, odd = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            return (even, odd);
        }

        public bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public List<int> FindDuplicates(int[] arr)
        {
            List<int> duplicates = new List<int>();
            HashSet<int> seen = new HashSet<int>();
            foreach (int num in arr)
            {
                if (seen.Contains(num))
                {
                    duplicates.Add(num);
                }
                else
                {
                    seen.Add(num);
                }
            }
            return duplicates;
        }

        public int[] RightShift(int[] arr)
        {
            int[] shifted = new int[arr.Length];
            shifted[0] = arr[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
            {
                shifted[i] = arr[i - 1];
            }
            return shifted;
        }

        public int CountOccurrences(int[] arr, int target)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num == target)
                {
                    count++;
                }
            }
            return count;
        }


        public int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            int[] merged = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    merged[k++] = arr1[i++];
                }
                else
                {
                    merged[k++] = arr2[j++];
                }
            }
            while (i < arr1.Length)
            {
                merged[k++] = arr1[i++];
            }
            while (j < arr2.Length)
            {
                merged[k++] = arr2[j++];
            }
            return merged;
        }

        public int FindSecondLargest(int[] arr)
        {
            int first = int.MinValue, second = int.MinValue;
            foreach (int num in arr)
            {
                if (num > first)
                {
                    second = first;
                    first = num;
                }
                else if (num > second && num != first)
                {
                    second = num;
                }
            }
            return second;
        }
    }
}