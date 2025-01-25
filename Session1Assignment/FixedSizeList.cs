using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Assignment
{
    internal class FixedSizeList<T>
    {
        private readonly T[] items; 
        private int count;

        public FixedSizeList(int capacity)
        {
            items = new T[capacity];
            count = 0;
        }
        public void Add(T item)
        {
            if (count >= items.Length)
            {
                Console.WriteLine("List is full");
                return; 
            }
            else
            {
                items[count] = item; 
                count++;
            }
        }


        public T Get(int index)
        {
            if (index < 0 || index >= count) 
            {
                Console.WriteLine("Invalid index. Cannot retrieve element.");
                return (T)(object)-1;
            }
            return items[index]; 
        }

        public void PrintContents()
        {
            for (int i = 0; i < count; i++) 
            {
                Console.Write(items[i] + " ");
            }
        }
    }
}
