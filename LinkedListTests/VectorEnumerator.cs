using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListTests
{
    internal class VectorEnumerator<T> : IEnumerator<T>
    {
        private Node<T> current;
        private Node<T> first;

        public VectorEnumerator(Node<T> root)
        {
            var virtualnode = new Node<T>();
            virtualnode.Next = root;
            this.current = virtualnode;
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
                current = current.Next;
            }
            return (current != null);
        }

        public void Reset()
        {
            current = first;
        }
    }
}