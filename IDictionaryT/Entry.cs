namespace IDictionaryT
{
    internal class Entry<TKey, TValue>
    {
        private TKey key;
        private TValue value;

        public Entry( TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }
    }
}