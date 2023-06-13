
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    class MemberException : Exception
    {
        public int Value { get; }
        public MemberException(string message, int val) : base(message)
        {
            Value = val;
        }
    }
    class LenghtException : Exception
    {
        public string Value { get; }
        public LenghtException(string message, string val) : base(message)
        {
            Value = val;
        }
    }

    class NameException : ArgumentException
    {
        public NameException() { }
    }

}
