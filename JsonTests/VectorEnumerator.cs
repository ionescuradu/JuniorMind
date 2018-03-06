using System;
using System.Collections;
using System.Collections.Generic;

namespace JsonTests
{
    internal class VectorEnumerator<T> : IEnumerator<T>
    {
        private T[] givenList;
        private int position = -1;
        private int count;

        public VectorEnumerator(T[] givenList, int count)
        {
            this.givenList = givenList;
            this.count = count;
        }

        public T Current
        {
            get
            {
                return givenList[position];
            }

        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position++;
            return (position < count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}