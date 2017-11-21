using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListTests
{
    internal class VectorEnumerator<T> : IEnumerator<T>
    {
        private Node<T> root;

        public VectorEnumerator(Node<T> root)
        {
            this.root = root;
        }

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            return (root.Next != null);
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}