using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListTests
{
    internal class VectorEnumerator<T> : IEnumerator<T>
    {
        private Node<T> current;

        public VectorEnumerator(Node<T> root)
        {
            this.current = root;
        }

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            return (current.Next == null);
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}