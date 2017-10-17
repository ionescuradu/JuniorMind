using System;
using System.Collections;

namespace IListTests
{
    class List : IList
    {
        private object[] givenList;
        private int count;

        public List (int initialCapacity)
        {
            count = 0;
            givenList = new object[initialCapacity];
        }
        

        public object this[int index]
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

        public bool IsReadOnly => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public int Count
        {
            get
            {
                return count;
            }
        }

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public int Add(object value)
        {
            if (count == givenList.Length)
            {
                Array.Resize(ref givenList, givenList.Length * 2);
            }
            givenList[count] = value;
            count++;
            return count - 1;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return new VectorEnumerator(givenList);
        }

        public int IndexOf(object value)
        {
            var position = -1;
            for (int i = 0; i < count; i++)
            {
                if (givenList[i] == value)
                {
                    position = i;
                }
            }
            return position;
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            {
                for (int i = index; i < count - 1; i++)
                {
                    givenList[i] = givenList[i + 1];
                }
                count--;
            }
        }
    }
}