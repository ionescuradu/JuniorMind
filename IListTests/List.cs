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
            count++ ;
            return count - 1;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < count; i++)
            {
                if (givenList[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < count; i++)
            {
                array.SetValue(givenList[i], index);
                index++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new VectorEnumerator(givenList, count);
        }

        public int IndexOf(object value)
        {
            var position = -1;
            for (int i = 0; i < Count; i++)
            {
                if (givenList[i].Equals(value))
                {
                    position = i;
                    break;
                }
            }
            return position;
        }

        public void Insert(int index, object value)
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
            givenList[index] = value;
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if (index > -1)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    givenList[i] = givenList[i + 1];
                }
                count--;
            }
        }
    }
}