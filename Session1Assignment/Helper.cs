using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Assignment
{
    internal class Helper
    {
        #region Question1
        public static void OptimizedBubbleSort<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
        #endregion



        #region Question3
        public static void ReversedArray(ArrayList arrayList)
        {
            int start = 0;
            int end = arrayList.Count - 1;

            while (start < end)
            {
                var temp = arrayList[start];
                arrayList[start] = arrayList[end];
                arrayList[end] = temp;

                start++;
                end--;
            }
        }
        #endregion



        #region Question4
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    evenNumbers.Add(n);
                }
            }

            return evenNumbers;
        }
        #endregion


        #region Question6
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        } 
        #endregion

        public static void Print<T>(T[] Arr)
        {
            foreach (T i in Arr)
            {
                Console.Write(i + " ");
            }
        }

    }
}
