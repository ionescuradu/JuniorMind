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
            var aux = node.Next;
            var newNode = new Node<T>();
            var count = 0;
            var inserted = false;
            while (inserted == false)
            {
                if (index == 0)
                {
                    Add(item);
                    inserted = true;
                }
                else
                {
                    if (count == index - 1)
                    {
                        newNode.Value = item;
                        newNode.Next = aux;
                        newNode.Previous = node;
                        node.Next = newNode;
                        aux.Previous = newNode;
                        inserted = true;
                    }
                    else
                    {
                        count++;
                        node = node.Next;
                        aux = node.Next;
                    }
                }
                
            }
            
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
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            bool contains = false;
            var newNode = root;
            while (newNode != null)
            {
                if (newNode.Value.Equals(item))
                {
                    contains = true;
                    return contains;
                }
                else
                {
                    newNode = newNode.Next;
                }
            }
            return contains;
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
                if (newNode == null)
                {
                    break;
                }
            }
            return removed;
        }

        public void RemoveFirst()
        {
            var newNode = root;
            var aux = new Node<T>();
            while (newNode.Next != null)
            {
                aux = newNode;
                newNode = newNode.Next;
            }
            aux.Next = null;
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