﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListTests
{
    internal class List<T> : IList<T>
    {
        private Node<T> root;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();
            
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            var newNode = new Node<T>();
            newNode.Value = item;
            newNode.Next = root;
            root = newNode;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            new VectorEnumerator<T>(root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}