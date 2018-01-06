using System;
using System.Collections;
using System.Collections.Generic;

namespace IDictionaryT
{
    internal class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private List<Entry<TKey, TValue>>[] dictionary;
        private int count;
        private int initalCapacity;

        public Dictionary(int initialCapacity)
        {
            dictionary = new List<Entry<TKey, TValue>>[initialCapacity];
            for (int i = 0; i < dictionary.Length; i++)
            {
                dictionary[i] = new List<Entry<TKey, TValue>>();
            }
            count = 0;
        }

        public TValue this[TKey key]
        {
            get
            {
                var searchBucket = key.GetHashCode() % dictionary.Length;
                foreach (Entry<TKey, TValue> entry in dictionary[searchBucket])
                {
                    if (!entry.FindValue(key).Equals(default(TValue)))
                    {
                        return entry.FindValue(key);
                    }
                }
                throw new KeyNotFoundException();
            }
            set
            {
                var searchBucket = key.GetHashCode() % dictionary.Length;
                foreach (Entry<TKey, TValue> entry in dictionary[searchBucket])
                {
                    if (entry.FindValue(key).Equals(default(TValue)))
                    {
                        dictionary[searchBucket].Add(new Entry<TKey, TValue>(key, value));
                    }
                }
            }
        }

        public ICollection<TKey> Keys => throw new NotImplementedException();

        public ICollection<TValue> Values => throw new NotImplementedException();

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(TKey key, TValue value)
        {
            var bucket = key.GetHashCode() % dictionary.Length;
            foreach (Entry<TKey, TValue> entry in dictionary[bucket])
            {
                if (entry.FindKey(key))
                {
                    throw new ArgumentException();
                }
            }
            dictionary[bucket].Add(new Entry<TKey, TValue>(key, value));
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            var auxKey = item.Key;
            var auxValue = item.Value;
            Add(auxKey, auxValue);
        }

        public void Clear()
        {
            for (int i = 0; i < dictionary.Length; i++)
            {
                dictionary[i] = new List<Entry<TKey, TValue>>();
            }
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            var auxKey = item.Key;
            var containingBucket = auxKey.GetHashCode() % dictionary.Length;
            foreach (Entry<TKey, TValue> entry in dictionary[containingBucket])
            {
                if ((ContainsKey(auxKey) == true) && (entry.FindValue(auxKey).Equals(item.Value)))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            var bucket = key.GetHashCode() % dictionary.Length;
            foreach (Entry<TKey,TValue> item in dictionary[bucket])
            {
                if (item.FindKey(key) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int position = 0; position < count; position++)
            {
                yield return new KeyValuePair<TKey, TValue>();
            }
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}