﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab8_1
{
    class index
    {
        public index(){}

        private int x;
        private int y;
        private int[] arr;

        public index(int x, int y)
        {
            this.x = x;
            this.y = y;
            arr = new int[2]{this.x, this.y};
        }

        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value;}
        }
    }
}
