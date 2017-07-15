using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMyDate
{
    class MyDate
    {
        private int year = 1;
        private int month = 1;
        private int day = 1;
        private string[] strMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                                       "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private string[] strDays = { "Sunday", "Monday", "Tuesday", "Wednesday"
                                       , "Thursday", "Friday", "Saturday"};

        private int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Boolean isLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            return true;
        }

        public Boolean isValidDate(int year, int month, int day)
        {
            if (year >= 1 && year <= 9999)
            {
                return true;
            }
            else if (month >= 1 && month <= 12)
            {
                return true;
            }
            else if (day == 28)
            {

            }
            else
            {
                return false;
            }
            Console.WriteLine("The date is valid");
            return true;
        }

        public int getDayOfWeek(int year, int month, int day)
        {
            return this.year;
            return this.month;
            return this.day;
        }

        public MyDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public void setDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public int getYear()
        {
            return this.year;
        }

        public int getMonth()
        {
            return this.month;
        }

        public int getDay()
        {
            return this.day;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public void setMonth(int month)
        {
            this.month = month;
        }

        public void setDay(int day)
        {
            this.day = day;
        }

        public string tostring()
        {
            return string.Format(day + " " + month + " " + year);
        }

        public MyDate nextDay()
        {
            if (day >= 31)
            {
                day = 1;
                month++;
                if (month >= 12)
                {
                    month = 1;
                    year++;
                    if (year >= 1 && year <= 9999)
                    {
                        year++;
                    }
                }
            }
            return this;
        }

        public MyDate nextMonth()
        {
            if (month >= 1 && month <= 12)
            {
                month = 1;
                year++;

                if (year >= 1 && year <= 9999)
                {
                    year++;

                    if (day >= 31)
                    {
                        day = 1;
                        month++;
                    }
                }
            }
            return this;
        }

        public MyDate nextYear()
        {
            if (year >= 1 && year <= 9999)
            {
                year++;
                month = 1;

                if (day >= 31)
                {
                    day = 1;
                    month++;

                    if (month >= 1 && month <= 12)
                    {
                        month++;
                    }
                }
            }
            return this;
        }

        public MyDate previousDay()
        {
            if (day == 1)
            {
                day = 31;
                year--;

                if (year == 9999)
                {
                    year--;

                    if (month == 1)
                    {
                        month = 12;
                    }
                }
            }

            return this;
        }

        public MyDate previousMonth()
        {
            if (month == 1)
            {
                month = 12;
                year--;

                if (year == 9999)
                {
                    year--;
                    day = 31;

                    if (day == 1)
                    {
                        day = 31;

                    }
                }
            }
            return this;
        }

        public MyDate previousYear()
        {
            return this;
        }
    }
}
