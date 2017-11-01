using System;
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
                Array.Resize(ref givenList, givenList.Length * 2);
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
            for (int i = 0; i < count; i++)
            {
                array.SetValue(givenList[i], arrayIndex);
                arrayIndex++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new VectorEnumerator<T>(givenList, count);
        }

        public int IndexOf(T item)
        {
            var position = -1;
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
            if (count + 1 > givenList.Length)
            {
                Array.Resize(ref givenList, givenList.Length * 2);
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
            if (index > -1)
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}