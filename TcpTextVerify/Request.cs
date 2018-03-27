using System;
using System.Collections.Generic;
using System.Linq;
using JsonTests;
using TcpTextVerifyTests;

namespace TcpHtmlVerify
{
    public class Request : Match
    {
        private readonly Method method;
        private readonly Uri uri;
        private readonly Dictionary<string, string> fields;

        public Request(Match match)
        {
            var list = (match as MatchesArray).List;
            method = list
                .OfType<MethodMatch>()
                .First()
                .Method;
            uri = list
                .OfType<UriMatch>()
                .First()
                .Uri;
            fields = list
                .OfType<FieldsMatch>()
                .First()
                .Dictionary;
        }

        public bool Success => true;

        public Method Method => method;

        public Uri Uri => uri;

        public Dictionary<string, string> Fields => fields;
    }
}
