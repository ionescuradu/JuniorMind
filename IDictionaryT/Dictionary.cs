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
                if (FindKeyInBucket(key, dictionary, out var entry) == true)
                {
                    return entry.FindValue(key);
                }
                throw new KeyNotFoundException();
            }
            set
            {

                if (FindKeyInBucket(key, dictionary, out var entry) == false)
                {
                    dictionary[Bucket(key)].Add(new Entry<TKey, TValue>(key, value));
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
            if (FindKeyInBucket(key, dictionary, out var entry) == true)
            {
                throw new ArgumentException();
            }
            dictionary[Bucket(key)].Add(new Entry<TKey, TValue>(key, value));
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
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

            return FindKeyInBucket(item.Key, dictionary, out var entry);
        }

        public bool ContainsKey(TKey key)
        {
            return FindKeyInBucket(key, dictionary, out var entry);
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
            if (FindKeyInBucket(key, dictionary, out var entry) == true)
            {
                return dictionary[Bucket(key)].Remove(entry);
            }
            throw new ArgumentNullException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return Remove(item.Key);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (FindKeyInBucket(key, dictionary, out var entry) == true)
            {
                value = entry.FindValue(key);
                return true;
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

        private bool FindKeyInBucket(TKey key, List<Entry<TKey, TValue>>[] dictionary, out Entry<TKey, TValue> searchedEntry)
        {
            foreach (Entry<TKey, TValue> entry in dictionary[Bucket(key)])
            {
                if (entry.FindKey(key) == true)
                {
                    searchedEntry = entry;
                    return true;
                }
            }
            searchedEntry = new Entry<TKey, TValue>(default(TKey), default(TValue));
            return false;
        }
    }
}