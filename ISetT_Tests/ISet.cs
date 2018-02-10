using System;
using System.Collections;
using System.Collections.Generic;

namespace ISetT_Tests
{
    class Set<T> : ISet<T>
    {
        private int[] buckets;
        private Entry<T>[] entries;
        private int intialCapacity;
        private int count;

        public Set(int initialCapacity)
        {
            buckets = new int[initialCapacity];
            entries = new Entry<T>[initialCapacity];
            for (int i = 0; i < initialCapacity; i++)
            {
                buckets[i] = -1;
                entries[i] = default(Entry<T>);
            }
            count = 0;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public bool Add(T item)
        {
            if (buckets[GetBucket(item)] == -1)
            {
                entries[count] = new Entry<T>(item);
                buckets[GetBucket(item)] = count;
                entries[count].next = -1;
                count++;
                return true;
            }
            if (Contains(item))
            {
                return false;
            }
            else
            {
                entries[count] = new Entry<T>(item);
                entries[buckets[GetBucket(item)]].next = count;
                entries[count].next = -1;
                count++;
                return true;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = -1;
                entries[i] = default(Entry<T>);
            }
            count = 0;
        }

        public bool Contains(T item)
        {
            var index = buckets[GetBucket(item)];
            if (index == -1)
            {
                return false;
            }
            do
            {
                if (entries[index].CompareKey(new Entry<T>(item)))
                {
                    return true;
                }
                index = entries[index].next;
            } while (index != -1);
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            if (!Contains(item))
            {
                return false;
            }
            return true;
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public void UnionWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int GetBucket(T key)
        {
            return key.GetHashCode() % buckets.Length;
        }
    }
}
