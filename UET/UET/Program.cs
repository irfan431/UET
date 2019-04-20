using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UET
{
    class Program
    {
        static void Main(string[] args)
        {
            date2019 _date2019 = new date2019();

            Console.Write("Enter a month: ");
            int month = int.Parse(Console.ReadLine());
            #region monthRegin
            monthRegin: //labels
            if (month > 0 && month <= 12)
            {
                
            }
            else
            {
                Console.Write("Enter a correct month between 1-12: ");
                month = int.Parse(Console.ReadLine());
                goto monthRegin; //go back to label
            }
            #endregion
            
            Console.WriteLine();
            Console.Write("Enter a day: ");
            int day = int.Parse(Console.ReadLine());
            #region dayRegin
            dayRegin:
            if (day > 0 && day <= 31)
            {
               
            }
            else
            {
                Console.Write("Enter correct day (e.g. for 1-31 for January, 1-28 for February) ");
                day = int.Parse(Console.ReadLine());
                goto dayRegin;
            }
            #endregion
            
            Console.WriteLine();
            Console.Write("Enter a days after: ");
            int daysafter = int.Parse(Console.ReadLine());
            #region yearRegin
            yearRegin:
            if (daysafter > 0)
            {
                
            }
            else
            {
                Console.Write("Enter a correct year : ");
                daysafter = int.Parse(Console.ReadLine());
                goto yearRegin;
            }
            #endregion
            _date2019.setdate(day, month);
            _date2019.plusday(daysafter);
            _date2019.print();
            Console.ReadLine();
        }
    }
    class date2019
    {
        int month { get; set; }
        int dayofmonth { get; set; }
        int plusDays { get; set; }
        DateTime FirstDateOfYear { get; set; }
        DateTime NextDate { get; set; }
        public date2019()
        {
            FirstDateOfYear = new DateTime(DateTime.Now.Year, 1, 1);
        }

        public date2019(int dd)
        {
            FirstDateOfYear.AddDays(dd);
        }
        public date2019(int dd, int mm)
        {
            FirstDateOfYear = new DateTime(FirstDateOfYear.Year, mm, dd);
        }

        public void setdate(int dd, int mm)
        {
            month = mm;
            dayofmonth = dd;
            FirstDateOfYear = FirstDateOfYear.AddMonths(mm);
            FirstDateOfYear = FirstDateOfYear.AddDays(dd);

        }
        public void print()
        {
            if (NextDate.Year > 2019)
            {
                Console.WriteLine();
                Console.Write("{0} days after {1},{2}", plusDays, FirstDateOfYear.ToString("dddd, dd MMMM yyyy"), " is a date not in 2019");

            }
            else
            {
                Console.WriteLine();
                Console.Write("{0} days after {1},{2}", plusDays, FirstDateOfYear.ToString("dddd, dd MMMM yyyy"), NextDate.ToString("dddd, dd MMMM yyyy"));
            }
        }
        public void plusday(int days)
        {
            plusDays = days;
            NextDate = FirstDateOfYear.AddDays(days);
        }


    }

}
