﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    public class SuccessMatch : Match
    {
        private string foundString;

        public SuccessMatch(string foundString)
        {
            this.foundString = foundString;
        }

        public bool Success
        {
            get
            {
                return true;
            }
        }

        public override bool Equals(object obj)
        {
            return foundString.Equals(obj);
        }

        public override string ToString()
        {
            return foundString;
        }
    }
}