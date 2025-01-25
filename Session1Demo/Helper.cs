using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Demo
{
    //Generic Constraint [0,1]
    //1.Primary Constraint
    //1.1 class
    //1.1 struct
    //1.1 specific type point
    //1.1 enum
    //1.1 notnull


    //2.Secondry Constraint [0,M]
    //2.1 implement interface

    //3.Constructor Constraint

    internal static class Helper/*<T>*/
    {
        //T :must be type which implement the IComparable interface
        //Generic Bubble sort
        public static void BubbleSort<T>(T[] Arr) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i- 1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j+1]) > 0)
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }

        public static void BubbleSort<T>(T[] Arr,IComparer<T> comparer) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (comparer.Compare(Arr[j], Arr[j+1])>0)
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }

        #region Non-Generic BubbleSort
        ////Generic Bubble sort
        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length-1; j++)
        //            {
        //                if (Arr[j] > Arr[j+1])
        //                {
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //} 
        #endregion


        public static void Print<T>(T[] Arr)
        {
            foreach (T i in Arr)
            {
                Console.WriteLine(i);
            }
        }

        #region Generic Linear Search
        //Linear search
        public static int LinearSearch<T>(T[] Arr, T value)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(value))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }


        public static int LinearSearch<T>(T[] Arr, T value, IEqualityComparer<T> equalityComparer) 
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (equalityComparer.Equals(Arr[i],value))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        #endregion

        #region Non-Generic Linear Search
        //public static int LinearSearch(int[] Arr,int value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] == value)
        //            {
        //                return i;
        //            }
        //        }
        //    }
        //    return -1;
        //} 
        #endregion

        #region Generic-SWAP
        //// Generic SWAP Method

        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        //public static void Print(string data)
        //{
        //    Console.WriteLine(data);
        //} 

        //public static void Welcome<T1>(T1 t1)
        //{ 

        //}
        #endregion

        #region Non-Generic SWAP
        //public static void SWAP(ref int X , ref int Y)
        //{
        //    int Temp = X;
        //    X = Y; 
        //    Y = Temp;
        //}

        //public static void SWAP(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref Point X, ref Point Y)
        //{
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion
    }
}
