using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListTests
{
    internal class VectorEnumeratorReverse<T> : IEnumerator<T>
    {
        private Node<T> current;
        private Node<T> first;

        public VectorEnumeratorReverse(Node<T> root)
        {
            this.current = root;
            first = root;
        }

        public T Current => current.Value;

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (current != null)
            {
                current = current.Previous;
            }
            return (current != first);
        }

        public void Reset()
        {
            current = null;
        }
    }
}