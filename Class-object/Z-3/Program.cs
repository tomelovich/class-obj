using System;

namespace Z_3
{
    class Dat
    {
        int iDay;
        int iMonth;
        int iYear;

        static int[] DayOfMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public Dat(int Day, int Month, int Year)
        {
            iDay = Day;
            iMonth = Month;
            iYear = Year;
            CheckOfDate();
        }

        public void ChangeDay(int d)
        {
            iDay += d;
            CheckOfDate();
        }

        public void ChangeMonth(int m)
        {
            iMonth += m;
            CheckOfDate();
        }

        public void ChangeYear(int y)
        {
            iYear += y;
            CheckOfDate();
        }

        void CheckOfDate()
        {
            try
            {
                if (iYear < 0)
                {
                    throw (new SystemException());
                }
                if ((iMonth < 1) || (iMonth > 12))
                {
                    throw (new SystemException());
                }
                if ((iDay < 0) || (iDay > DayOfMonth[iMonth - 1]))
                {
                    throw (new SystemException());
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("Неправильная дата");

            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dat d = new Dat(27, 7, 123);
            d.ChangeDay(-3);
            d.ChangeMonth(2);
            d.ChangeYear(777);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}