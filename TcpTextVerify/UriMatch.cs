using System;
using JsonTests;

namespace TcpHtmlVerify
{
    public class UriMatch : Match
    {
        private readonly Uri uri;

        public UriMatch(string text)
        {
            uri = new Uri(text,UriKind.Relative);
        }

        public Uri Uri => uri;

        public bool Success => true;

    }
}
