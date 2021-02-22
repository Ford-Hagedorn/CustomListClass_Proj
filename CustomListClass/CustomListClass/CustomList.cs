using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        private T[] _numbers;
        private int count;
        private int capacity;

        public CustomList()
        {
            count = 0;
            capacity = 4;
            _numbers = new T[capacity];
        }

        public void Add(T numberToAdd)
        {
            if (count == capacity)
            {
                capacity++;
                
            }
            _numbers[count] = numberToAdd;
            count++;
        }

        public void Subtract(T numberToSubtract)
        {
            _numbers[count] = numberToSubtract;
            count--;
        }
    }
}
