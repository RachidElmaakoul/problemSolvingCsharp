using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace FirstProblem1
{
    public class Date
    {

        private static readonly int[] NumberDayOfYear365 = { 0, 30, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] NumberDayOfYear366 = { 0, 30, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        private readonly int day;
        private readonly int month;
        private readonly int year;


        public Date(int day, int month, int year)
        {
            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            if (year >= 1 && year <= 9999 && month <= 12 && month >= 1)
            {
                int[] Days = isLeap ? NumberDayOfYear366 : NumberDayOfYear365;

                if (day >= 1 && day <= Days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
            }
        }

        public void Printdate()
        {
            Console.WriteLine($"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')}");
        }

    }
}
