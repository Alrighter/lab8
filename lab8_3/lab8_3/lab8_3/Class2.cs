using System;
using System.Collections.Generic;
using System.Text;

namespace lab8_3
{
    class Class2 : Class1
    {
        private protected char[] _array;
        private int[] resultLength;

        public Class2(int Length) : base(Length)
        {
            _array = new char[Length];
            resultLength = new int[2] { Length, base.ArrayLength };
        }

        public new int[] ArrayLength
        {
            get
            {
                return resultLength;
            }
        }

        public char this[char index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
    }
}
