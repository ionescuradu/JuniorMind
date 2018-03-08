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
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n')
                {
                    Line++;
                    Column = 0;
                }
                if (i == index)
                {
                    Column = i + 1;
                }
            }
        }

        public int Line { get; internal set; }
        public int Column { get; internal set; }
    }
}