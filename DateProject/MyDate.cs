using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    class MyDate
    {
        private int _day;
        private int _month;
        private int _year;
        private static int[] MonthDays = {0,31,31,31,31,31,31,30,30,30,30,30,29};
        public int Day
        {
            set
            {
                if(value>=0 && value <= MonthDays[Month])
                _day = value;
                else
                {
                    Day = 1;
                }
            }
            get
            {
                return _day;
            }
        }
        public int Month
        {
            set
            {
                if (value >= 0 && value <= 12)
                    _month = value;
                else
                    Month = 1;
            }
            get
            {
                return _month;
            }
        }
        public int Year
        {
            set
            {
                if (value >= 1300 /*&& value <= 1500*/)
                    _year = value;
                else
                    Year = 1398;
            }
            get
            {
                return _year;
            }
        }
        public MyDate(int d=1 ,int m=1, int y=1300)
        {
            Month = m;
            Day = d;
            Year = y;
        }
        public MyDate(MyDate x)
        {
            Month = x.Month;
            Day = x.Day;
            Year = x.Year;
        }
        public override string ToString()
        {
            return Year + "/" + (Month<10?"0":"")+ Month + "/"+(Day<10?"0":"") + Day;
        }
        private bool EndOfMonth()
        {
            if (Day == MonthDays[Month])
                return true;
            else
                return false;
        }
        private void Increment()
        {
            if(Month==12 && EndOfMonth())
            {
                Year++;
                Month = 1;
                Day = 1;
            }
            else if (EndOfMonth())
            {
                Month++;
                Day = 1;
            }
            else
            {
                Day++;
            }
        }
        private void Decrement()
        {
            if (Month == 12 && EndOfMonth())
            {
                Year--;
                Month = 1;
                Day = 1;
            }
            else if (EndOfMonth())
            {
                Month--;
                Day = 1;
            }
            else
            {
                Day--;
            }
        }
        public MyDate Add1(int n)
        {
            for (int i = 1; i <= n; i++)
                Increment();
            return this;
        }
        public MyDate Add2(int n)
        {
            MyDate temp = new MyDate(this);
            for (int i = 1; i <= n; i++)
                temp.Increment();
            return temp;
        }
        public MyDate Remove(int n)
        {
            MyDate temp = new MyDate(this);
            for (int i = 1; i <= n; i++)
                temp.Decrement();
            return temp;
        }
        public static MyDate operator +(MyDate x,int n)
        {
            MyDate temp = new MyDate(x);
            for (int i = 0; i < n; i++)
                temp.Increment();
            return temp;
        }
        public static MyDate operator +(int n,MyDate x)
        {
            MyDate temp = new MyDate(x);
            for (int i = 0; i < n; i++)
                temp.Increment();
            return temp;
        }
        public static bool operator>(MyDate x,MyDate y)
        {
            if (x.Year > y.Year || (x.Year == y.Year && x.Month > y.Month) || (x.Year == y.Year && x.Month == y.Month && x.Day > y.Day))
                return true;
            else
                return false;
        }
        public static bool operator <(MyDate x, MyDate y)
        {
            if (x.Year < y.Year || (x.Year == y.Year && x.Month < y.Month) || (x.Year == y.Year && x.Month == y.Month && x.Day < y.Day))
                return true;
            else
                return false;
        }
        public static MyDate operator ++(MyDate x)
        {
            MyDate temp = new MyDate(x);
            temp.Increment();
            return temp;
        }
        public static MyDate operator --(MyDate x)
        {
            MyDate temp = new MyDate(x);
            temp.Decrement();
            return temp;
        }
        public static explicit operator int(MyDate x)
        {
            int n = 0;
            for (int i = 1; i < x.Month; i++)
                n += MonthDays[i];
            n += x.Day;
            return n;
        }
        public static implicit operator string(MyDate x)
        {
            return x.ToString();
        }
        public static bool operator true(MyDate x)
        {
            return (x.Day == 1 && x.Month == 1);
        }
        public static bool operator false(MyDate x)
        {
            return !(x.Day == 1 && x.Month == 1);
        }
    }
}
