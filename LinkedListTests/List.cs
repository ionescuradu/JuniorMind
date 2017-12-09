using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListTests
{
    internal class List<T> : IEnumerable<T>
    {
        private Node<T> root;

        public List()
        {
            root = new Node<T>();
            root.Next = root;
            root.Previous = root;
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            var node = root.Next;
            var newNode = new Node<T>();
            newNode.Value = item;
            FindNode(index, ref node);
            if (index == 0)
            {
                AddFirst(item);
            }
            else
            {
                node = node.Previous;
                newNode.Next = node.Next;
                newNode.Previous = node;
                node.Next = newNode;
                node.Next.Next.Previous = newNode;
            }
        }

        public Node<T> FindNode(int index, ref Node<T> node)
        {
            var count = 0;
            while (count != index)
            {
                node = node.Next;
                count++;
            }
            return node;
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            var newNode = new Node<T>();
            AddLast(item, newNode);
        }

        public void AddLast(T item, Node<T> newNode)
        {
            newNode.Value = item;
            newNode.Next = root;
            newNode.Previous = root.Previous;
            root.Previous.Next = newNode;
            root.Previous = newNode;
        }

        public void AddFirst(T item)
        {
            var newNode = new Node<T>();
            newNode.Value = item;
            newNode.Next = root.Next;
            newNode.Previous = root;
            root.Next = newNode;
            root.Next.Next.Previous = newNode;
        }

        public void Clear()
        {
            root.Next = root;
            root.Previous = root;
        }

        public bool Contains(T item)
        {
            if (FindFirst(item) == root)
            {
                return false;
            }
            return true;
        }

        public bool ContainsLast(T item)
        {
            if (FindLast(item) == root)
            {
                return false;
            }
            return true;
        }

        public Node<T> FindFirst(T item)
        {
            var first = root.Next;
            while (first != root)
            {
                if (first.Value.Equals(item))
                {
                    return first;
                }
                else
                {
                    first = first.Next;
                }
            }
            return first;
        }

        public Node<T> FindLast(T item)
        {
            var last = root.Previous;
            while (last != root)
            {
                if (last.Value.Equals(item))
                {
                    return last;
                }
                else
                {
                    last = last.Previous;
                }
            }
            return last;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            var removed = false;
            var node = FindFirst(item);
            if (node != root)
            {
                node.Previous = node.Next;
                removed = true;
            }
            return removed;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new VectorEnumerator<T>(root);
        }

        public IEnumerator<T> GetReverseEnumerator()
        {
            return new VectorEnumeratorReverse<T>(root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}