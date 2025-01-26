using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_c_1.Q4
{
    internal class FixedSizeList<T>
    {
        public int Max { get; set; }
        public T[] Values { get; set; }

        public int count;

        public FixedSizeList(int max)
        {
            Max = max;
            Values = new T[max];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= Max)
            {
                Console.WriteLine("Cannot add more elements. The list is full.");
                return;
            }
            else
            {
                Values[count] = item;
                count++;
            }
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Invalid index. Index must be within the range of the list.");
            }

            return Values[index];
        }
    }
}
