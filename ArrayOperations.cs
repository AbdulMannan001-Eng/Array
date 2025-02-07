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
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }


        public int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
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
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
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

            for (int i = 0; i < arr.Length; i++)
            {
                if (seen.Contains(arr[i]))
                {
                    duplicates.Add(arr[i]);
                }
                else
                {
                    seen.Add(arr[i]);
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
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    count++;
                }
            }
            return count;
        }


        public int[] SortArrays(int[] arr1, int[] arr2)
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
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }
            return second;
        }
    }
}