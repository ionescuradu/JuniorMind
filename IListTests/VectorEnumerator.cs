using System;
using System.Collections;

namespace IListTests
{
    internal class VectorEnumerator : IEnumerator
    {
        private object[] givenList;
        private int position = -1;
        private int count;

        public VectorEnumerator(object[] givenList, int count)
        {
            this.givenList = givenList;
            this.count = count;
        }

        public bool MoveNext()
        {
             position++;
            return (position < givenList.Length);
        }

        public object Current
        {
            get
            {
                return givenList[position];
            }
            
        }

        public void Reset()
        {
            position = -1;
        }
    }
}