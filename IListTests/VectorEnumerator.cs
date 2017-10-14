using System;
using System.Collections;

namespace IListTests
{
    internal class VectorEnumerator : IEnumerator
    {
        private object[] givenList;
        int position = -1;

        public VectorEnumerator(object[] givenList)
        {
            this.givenList = givenList;
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