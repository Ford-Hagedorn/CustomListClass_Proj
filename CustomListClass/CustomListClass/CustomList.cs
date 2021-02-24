using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        public T[] _numbers;
        private int count;
        public int Count { get => count; }


        private int capacity;

        public int Capacity { get => capacity; }
        public T this[int index] { get => _numbers[index]; set => _numbers[index] = value; }


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
                capacity = capacity * 2;
                T[] biggerNumber = new T[capacity];
                _numbers[count] = numberToAdd;
                for (int i = 0; i < count; i++)
                {
                    biggerNumber[i] = _numbers[i];
                }
                _numbers = biggerNumber;
                
            }
            _numbers[count] = numberToAdd;
            count++;

        }

        public void Remove(T numberToSubtract)
        {
            _numbers[count] = numberToSubtract;
            count--;
        }
    }
}
