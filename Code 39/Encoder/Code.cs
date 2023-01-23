using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_39.Encoder
{
    // [Code Model Definition Class]
    class Code
    {
        // [Properties]
        // Properties are read-only; due to security reseans.
        public char Symbol { get; }
        public string[] Pattern { get; }

        // [Constructor]
        public Code() { }
        public Code(char symbol, string[] pattern)
        {
            Symbol = symbol;
            Pattern = pattern;
        }

    }
}
