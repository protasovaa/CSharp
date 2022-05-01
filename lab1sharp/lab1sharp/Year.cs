using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1sharpSasha
{
    public class Year
    {
        private int year;
        public Month mm { get; set; }
        public Day dd { get; set; }
        public Year(int year)
        {
            this.year = year;
        }
        public int getYear()
        {
            return year;
        }
        public void addMonth(Month month)
        {
            mm = month;
        }
        public void addDay(Day day)
        {
            dd = day;
        }
        public string what_day(Year year)
        {
            int a = (14 - year.mm.getMonth()) / 12;
            int y = year.getYear() - a;
            int m = year.mm.getMonth() + 12 * a - 2;
            int res = (7000 + (year.dd.getDay() + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12)) % 7;
            switch (res)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 0:
                    return "Воскресенье";
                default:
                    return null;
                
            }
        }
}
}

