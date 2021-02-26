using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        private T[] items;
        private int count;
        public int Count { get => count; }


        private int capacity;

        public int Capacity { get => capacity; }
        public T this[int index] { get => items[index]; set => items[index] = value; }


        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public void Add(T numberToAdd)
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] biggerNumber = new T[capacity];
                items[count] = numberToAdd;
                for (int i = 0; i < count; i++)
                {
                    biggerNumber[i] = items[i];
                }
                items = biggerNumber;
                
            }
            items[count] = numberToAdd;
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
            //T[] numberSpread = new T[count];
            //T[] newNumberSpread = new T[count - 1];
            //bool removeItem = true;
            //int i = 0;
            //int j = 0;
            //while (i < numberSpread.Length)
            //{
            //    int numberRemove;
            //    numberRemove = count - 1;

            //    if (i != numberSpread.Length)
            //    {
            //        newNumberSpread[j] = numberSpread[i];
            //        j++;
            //    }
            //    i++;
            //}
            //be able to remove item from array
            //skip or remove
            //put remaining in new array
            //set array member variable to temp array w/o item that was removed

            T[] smallerItems = new T[capacity];
            bool isRemoved = false;
            for (int i = 0, j = 0; i < count; i++, j++)
            {
                if (items[i].Equals(numberToSubtract) && isRemoved == false)
                {
                    j--;
                    isRemoved = true;
                }
                else
                {
                    smallerItems[j] = items[i];
                }
                items = smallerItems;
                if (isRemoved)
                {
                    count--;

                }
                
            }
        }
        public static CustomList<T> Zip (CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> combinedList = new CustomList<T>();
            if (firstList.count > secondList.count)
            {
                for (int i = 0; i < firstList.count; i++)
                {
                    combinedList.Add(firstList[i]);
                }

            }
        }
    }
}
