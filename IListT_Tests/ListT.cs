﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace IListT_Tests
{
    class List<T> : IList<T>
    {
        private T[] givenList;
        private int count;
        bool removed;

        public List(int initialCapacity)
        {   
            count = 0;
            givenList = new T[initialCapacity];
        }

        public T this[int index]    
        {
            get
            {
                return givenList[index];
            }
            set
            {
                givenList[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (count == givenList.Length)
            {
                ResizeList();
            }
            givenList[count] = item;
            count++;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (givenList[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if ( array == null)
            {
                throw new ArgumentNullException();
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (array.Length - arrayIndex - count < 0)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < count; i++)
            {
                array.SetValue(givenList[i], arrayIndex);
                arrayIndex++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int position = 0; position < count; position++)
            {
               yield return givenList[position];
            }

        }

        public int IndexOf(T item)
        {
            var position = 0;
            for (int i = 0; i < Count; i++)
            {
                if (givenList[i].Equals(item))
                {
                    position = i;
                    break;
                }
            }
            return position;
        }

        public void Insert(int index, T item)
        {
            if ((index < 0) || (index > count))
            {
                throw new ArgumentOutOfRangeException();
            }
            if (count + 1 > givenList.Length)
            {
                ResizeList();
            }
            count++;
            for (int i = count - 1; i > index; i--)
            {
                givenList[i] = givenList[i - 1];
            }
            givenList[index] = item;
        }

        public bool Remove(T item)
        {
            RemoveAt(IndexOf(item));
            return removed == true;
        }

        public void RemoveAt(int index)
        {
            if ((index < 0) || (index >= count))
            {
                throw new ArgumentOutOfRangeException();
            }
            if (index > 0)
            {
                removed = false;
                for (int i = index; i <= Count - 1; i++)
                {
                    givenList[i] = givenList[i + 1];
                    removed = true;
                }
                count--;
            }
        }

        private void ResizeList()
        {
            Array.Resize(ref givenList, givenList.Length * 2);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}