using System;
using JsonTests;

namespace TcpHtmlVerify
{
    public class UriMatch : Match
    {
        private readonly string text;
        private string aux;

        public UriMatch(string text)
        {
            this.text = text;
        }

        public string IsUri()
        {
            if (Uri.IsWellFormedUriString(text, UriKind.RelativeOrAbsolute))
            {
                aux = text;
                return text;
            }
            return aux = "";
        }

        public bool Success => (text == aux);

    }
}
