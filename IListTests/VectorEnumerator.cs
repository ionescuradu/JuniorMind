using System;
using System.Collections;

namespace IListTests
{
    internal class VectorEnumerator : IEnumerator
    {
        private object[] givenList;
        private int position = -1;

        public VectorEnumerator(object[] givenList, int position)
        {
            this.givenList = givenList;
            this.position = position;
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