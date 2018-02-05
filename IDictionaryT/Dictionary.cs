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
                foreach (Entry<TKey, TValue> entry in dictionary[Bucket(key)])
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
                foreach (Entry<TKey, TValue> entry in dictionary[Bucket(key)])
                {
                    if (entry.FindValue(key).Equals(default(TValue)))
                    {
                        dictionary[Bucket(key)].Add(new Entry<TKey, TValue>(key, value));
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
            foreach (Entry<TKey, TValue> entry in dictionary[Bucket(key)])
            {
                if (entry.FindKey(key))
                {
                    throw new ArgumentException();
                }
            }
            dictionary[Bucket(key)].Add(new Entry<TKey, TValue>(key, value));
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
            foreach (Entry<TKey, TValue> entry in dictionary[Bucket(item.Key)])
            {
                if ((ContainsKey(item.Key) == true))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            foreach (Entry<TKey,TValue> item in dictionary[Bucket(key)])
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
            foreach (Entry<TKey, TValue> entry in dictionary[Bucket(key)])
            {
                if (entry.FindKey(key))
                {
                    return dictionary[Bucket(key)].Remove(entry);
                }
            }
            throw new ArgumentNullException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return Remove(item.Key);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            foreach (Entry<TKey, TValue> entry in dictionary[Bucket(key)])
            {
                if (entry.FindKey(key).Equals(true))
                {
                    value = entry.FindValue(key);
                    return true;
                }
            }
            value = default(TValue);
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Bucket(TKey key)
        {
            return key.GetHashCode() % dictionary.Length;
        }
    }
}