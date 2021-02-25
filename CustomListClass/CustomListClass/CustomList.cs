using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        public T[] numbers;
        private int count;
        public int Count { get => count; }


        private int capacity;

        public int Capacity { get => capacity; }
        public T this[int index] { get => numbers[index]; set => numbers[index] = value; }


        public CustomList()
        {
            count = 0;
            capacity = 4;
            numbers = new T[capacity];
        }

        public void Add(T numberToAdd)
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] biggerNumber = new T[capacity];
                numbers[count] = numberToAdd;
                for (int i = 0; i < count; i++)
                {
                    biggerNumber[i] = numbers[i];
                }
                numbers = biggerNumber;
                
            }
            numbers[count] = numberToAdd;
            count++;

        }

        public void Remove(T numberToSubtract)
        {
            //make array with values : numberSpread
            //int value
            //bool removeValue(?)
            //remove first iteration of value, then stop
            //first iteration removed = true
            //keep going until the value is removed
            //T[] numberSpread = new T[count];
            //T[] newNumberSpread = new T[count - 1];
            //int i = 0;
            //int j = 0;
            //numbers[count] = numberToSubtract;
            //while (i < numberSpread.Length)
            //{
            //    if (i != numberToSubtract)
            //    {
            //        newNumberSpread[j] = numberSpread[i];
            //        j++;
            //    }
            //    i++;
            //}
            //count--;
            T[] numberSpread = new T[count];
            T[] newNumberSpread = new T[count - 1];
            bool removeItem = true;
            int i = 0;
            int j = 0;
            while (i < numberSpread.Length)
            {
                int numberRemove;


                if (i != numberRemove)
                {
                    
                }
            }

        }
    }
}
