using System;
using System.Collections.Generic;
using JsonTests;
using TcpTextVerifyTests;

namespace TcpHtmlVerify
{
    public class Request : Match
    {
        private readonly List<Match> list;

        public Request(List<Match> list)
        {
            this.list = list;
        }

        public bool Success => true;

        public Method Method
        {
            get
            {
                foreach (var item in list)
                {
                    if (item is MethodMatch)
                    {
                        return (item as MethodMatch).Method;
                    }
                }
                return new Method();
            }
        }

        public Uri Uri
        {
            get
            {
                foreach (var item in list)
                {
                    if (item is UriMatch)
                    {
                        return (item as UriMatch).Uri;
                    }
                }
                return new UriMatch("").Uri;
            }
        }

        public Dictionary<string, string> Fields
        {
            get
            {
                foreach (var item in list)
                {
                    if (item is FieldsMatch)
                    {
                        return (item as FieldsMatch).Dictionary;
                    }
                }
                return new Dictionary<string, string>();
            }
        }
    }
}
