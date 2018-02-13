using System;
using System.Collections;
using System.Collections.Generic;

namespace ISetT_Tests
{
    class Set<T> : ISet<T>
    {
        private int[] buckets;
        private readonly Entry<T>[] entries;
        private int freePosition = 0;
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
            if (Contains(item))
            {
                return false;
            }
            var bucketIndex = GetBucket(item);
            if (freePosition == -1)
            {
                freePosition = count;
            }
            entries[freePosition] = new Entry<T>(item)
            {
                Next = buckets[bucketIndex]
            };
            buckets[bucketIndex] = freePosition;
            count++;
            freePosition = count;
            return true;
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
                index = entries[index].Next;
            } while (index != -1);
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                if (Contains(item))
                {
                    Remove(item);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int position = 0; position < entries.Length; position++)
            {
                yield return entries[position].Key;
            }
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            foreach (var entry in entries)
            {
                bool found = false;
                if (entry == null)
                {
                    continue;
                }
                foreach (var item in other)
                {
                    if (item.Equals(entry.Key))
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    Remove(entry.Key);
                }
            }
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            foreach (var entry in entries)
            {
                bool subset = false;
                if (entry == null)
                {
                    continue;
                }
                foreach (var item in other)
                {
                    if (entry.Key.Equals(item))
                    {
                        subset = true;
                    }
                }
                if (!subset)
                {
                    return false;
                }
            }

            return OtherCount(other) > count;
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                bool found = false;
                foreach (var entry in entries)
                {
                    if (entry.Key.Equals(item))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return false;
                }
            }
            return count > OtherCount(other);
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            return Compare(other);
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                bool found = false;
                foreach (var entry in entries)
                {
                    if (entry.Key.Equals(item))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return false;
                }
            }
            return count >= OtherCount(other);
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            bool removed = false;
            var auxEntry = entries[0];
            var index = buckets[GetBucket(item)];
            if (!Contains(item))
            {
                return false;
            }
            do
            {
                if (entries[index].CompareKey(new Entry<T>(item)))
                {
                    auxEntry.Next = entries[index].Next;
                    count--;
                    entries[index] = null;
                    removed = true;
                    freePosition = index;
                    break;
                }
                auxEntry = entries[index];
                index = entries[index].Next;
            } while (!removed);
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
            Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int position = 0; position < count; position++)
            {
                yield return entries[position];
            }
        }

        public int GetBucket(T key)
        {
            return key.GetHashCode() % buckets.Length;
        }

        public int OtherCount(IEnumerable<T> other)
        {
            var itemCount = 0;
            foreach (var item in other)
            {
                itemCount++;
            }
            return itemCount;
        }

        public bool Compare(IEnumerable<T> other)
        {
            foreach (var entry in entries)
            {
                bool found = false;
                if (entry == null)
                {
                    continue;
                }
                foreach (var item in other)
                {
                    if (entry.Key.Equals(item))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
