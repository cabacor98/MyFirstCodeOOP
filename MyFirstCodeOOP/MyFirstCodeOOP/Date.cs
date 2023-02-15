using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class Date
    {
        #region Properties
        public int _year;
        public int _month;
        public int _day;
        #endregion

        #region Constructor
        public Date(int year, int month, int day)
        {
            this._year = ValidateYear(year);
            this._month = ValidateMonth(month);    
            this._day = ValidateDay(day,month);
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{_year:0000}/{_month:00}/{_day:00}";
        }

        private int ValidateDay(int day, int month)
        {
            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day < 1 || day > daysInMonth[month])
            {
                throw new DayException("Day is invalid");
            }

            return day;
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new MonthException("Month is invalid");
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            throw new YearException("Year is invalid");
        }

        #endregion
    }
}
