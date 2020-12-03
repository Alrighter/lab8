using System;
using System.Collections.Generic;
using System.Text;

namespace lab8_3
{
    class Class1
    {
        private int _length;
        private protected int[] _array;

        public Class1(int Length)
        {
            this._length = Length;
            _array = new int[Length];
        }

        public virtual int ArrayLength
        {
            get { return _length; }
        }

        public int this[int index]
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
