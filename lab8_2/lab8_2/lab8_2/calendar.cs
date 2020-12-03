using System;
using System.Collections.Generic;
using System.Text;

namespace lab8_2
{
    class calendar
    {
        public calendar(){}

        private int day;
        private int month;
        private int year;

        public calendar(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        public int calculate(int day, int month, int year)
        {
            int result = -1 * (day - this.day + ((month - this.month) * 30) + ((year - this.year) * 365));
            return result;
        }


    }
}
