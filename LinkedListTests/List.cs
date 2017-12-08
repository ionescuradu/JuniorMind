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
            var node = root;
            return FindFirst(item, node);
        }

        public bool FindFirst(T item, Node<T> node)
        {
            var first = false;
            while (first == false)
            {
                if (node.Value.Equals(item))
                {
                    first = true;
                }
                else
                {
                    node = node.Next;
                }
                if (node == root)
                {
                    break;
                }
            }
            return first;
        }

        public bool FindLast(T item, Node<T> node)
        {
            var last = false;
            while (last == false)
            {
                if (node.Value.Equals(item))
                {
                    last = true;
                }
                else
                {
                    node = node.Previous;
                }
                if (node == root)
                {
                    break;
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
            var newNode = root;
            var aux = newNode;
            while (removed == false)
            {
                if (newNode.Value.Equals(item))
                {
                    aux.Next = newNode.Next;
                    removed = true;
                }
                else
                {
                    aux = newNode;
                    newNode = newNode.Next;
                }
                if (newNode == root)
                {
                    break;
                }
            }
            return removed;
        }

        public void RemoveFirst()
        {
            root.Next = root.Next.Next;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new VectorEnumerator<T>(root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}