﻿using System.Collections.Generic;
using Xunit;

namespace TcpHtmlVerify
{
    public class FieldsMatchTests
    {
        [Fact]
        public void FieldsMatchSuccess()
        {
            var keyValueMatch = new FieldsMatch(
                "Server: nginx/1.13.9\r\nContent-Lenght: 112\r\n\r\n");
            Assert.True(keyValueMatch.Success);
        }

        [Fact]
        public void FieldsMatchDictionary2Fields()
        {
            var keyValueMatch = new FieldsMatch(
                "Server: nginx/1.13.9\r\nContent-Lenght: 112\r\n\r\n");
            Dictionary<string, string> dictionaryToCompare = new Dictionary<string, string>();
            dictionaryToCompare.Add("Server", "nginx/1.13.9");
            dictionaryToCompare.Add("Content-Lenght", "112");
            Assert.Equal(dictionaryToCompare,keyValueMatch.Dictionary);
        }

        [Fact]
        public void FieldsMatchDictionary2FieldsWithSeparator()
        {
            var keyValueMatch = new FieldsMatch(
                "Server: nginx/1.13.9\nContent-Lenght: 112");
            var x = keyValueMatch.Dictionary;
            Dictionary<string, string> dictionaryToCompare = new Dictionary<string, string>();
            dictionaryToCompare.Add("Server", "nginx/1.13.9");
            dictionaryToCompare.Add("Content-Lenght", "112");
            Assert.Equal(dictionaryToCompare, keyValueMatch.Dictionary);
        }

    }
}
