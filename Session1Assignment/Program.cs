using System.Collections;

namespace Session1Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //Question1
            //int[] Numbers = { 2, 6, 7, -1, 0, 8, 9, 3, 14, 13 };
            //Helper.Print(Numbers);
            //Console.WriteLine("\n==================After sort================\n");
            //Helper.OptimizedBubbleSort(Numbers);
            //Helper.Print(Numbers); 
            #endregion

            #region Question2
            ////Question2
            //Range<int> R01 = new Range<int>(5, 10);
            //Console.WriteLine($"Is 7 in range? {R01.IsInRange(7)}");  
            //Console.WriteLine($"Length of range: {R01.Length()}");   
            #endregion

            #region Question3
            ////Question3
            //ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\n==================After Reverse=================");

            //Helper.ReversedArray(list);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion

            #region Question4
            ////Question4
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> evenNumbers = Helper.GetEvenNumbers(numbers);

            //Console.WriteLine("Even Numbers:");
            //foreach (int num in evenNumbers)
            //{
            //    Console.Write(num + " ");
            //} 
            #endregion

            #region Question5
            ////Question5
            //FixedSizeList<int> list = new FixedSizeList<int>(5);

            //list.Add(10);
            //list.Add(20);
            //list.Add(30);

            //Console.WriteLine("Contents of the list:");
            //list.PrintContents();

            //Console.WriteLine($"Element at index 1: {list.Get(1)}");

            //Console.WriteLine($"Element at index 10: {list.Get(10)}");

            //list.Add(40);
            //list.Add(50);
            //list.Add(60); 

            //Console.WriteLine("Final contents of the list:");
            //list.PrintContents(); 
            #endregion

            #region Question6
            ////Question6
            //string input = "NNoouuraa";
            //int result = Helper.FirstUniqChar(input);

            //if (result != -1)
            //    Console.WriteLine($"The first non-repeated character is at index {result}.");
            //else
            //    Console.WriteLine("No non-repeated character found.");
            #endregion

        }
    }
}
