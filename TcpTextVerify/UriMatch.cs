using System;
using JsonTests;

namespace TcpHtmlVerify
{
    public class UriMatch : Match
    {
        private readonly string text;

        public UriMatch(string text)
        {
            this.text = text;
        }

        public string IsUri()
        {
            if (Uri.IsWellFormedUriString(text, UriKind.RelativeOrAbsolute))
            {
                return text;
            }
            return "";
        }

        public bool Success => true;

    }
}
