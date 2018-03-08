namespace JsonTests
{
    internal class Location
    {
        private string text;
        private int index;

        public Location(string text, int index)
        {
            this.text = text;
            this.index = index;

            Line = 1;
            Column = 1;
            for (int i = 0; i < index; i++)
            {
                if (text[i] == '\n')
                {
                    Line++;
                    Column = 0;
                    continue;
                }
                Column++;
            }
        }

        public int Line { get; internal set; }
        public int Column { get; internal set; }
    }
}