using System;
using System.Collections.Generic;
using System.Globalization;

namespace TooT
{
    public static class DateTimeUtils
    {
        public static string MinutesToString(int m)
        {
            string r = "";
            int h = m / 60;
            m = m % 60;

            if (h > 0)
                r += h + " hora" + (h != 1 ? "s" : "");

            if (m > 0)
            {
                if (h > 0)
                {
                    r += ", ";
                }

                r += m + " minuto" + (m != 1 ? "s" : "");
            }

            return r;
        }

        public static List<DateTime> DaysInWeek(int week, int year)
        {
            List<DateTime> days = new List<DateTime>();
            CultureInfo ci = CultureInfo.CurrentCulture;
            DateTime day1 = new DateTime(year, 1, 1);
            int day1DayWeek = (int)day1.DayOfWeek;
            int offset = (day1DayWeek < 2 ? 1 : 4) - 2 * day1DayWeek;
            DateTime mon = day1.AddDays((day1DayWeek + offset) + ((week - 1) * 7));
            days.Add(mon);

            for (var i = 1; i <= 6; i++)
                days.Add(mon.AddDays(i));

            return days;
        }

        public static int TodayWeekNumber()
        {
            return DayWeekNumber(DateTime.Now);
        }

        public static int DayWeekNumber(DateTime day)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            return cal.GetWeekOfYear(day, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);
        }

        public static bool IsValidMonth(int m)
        {
            return m >= 1 && m <= 12;
        }

        public static int MonthToInt(string name)
        {
            int n = 0;
            name = name.ToLower();

            switch (name)
            {
                case "enero":
                    n = 1;
                    break;
                case "febrero":
                    n = 2;
                    break;
                case "marzo":
                    n = 3;
                    break;
                case "abril":
                    n = 4;
                    break;
                case "mayo":
                    n = 5;
                    break;
                case "junio":
                    n = 6;
                    break;
                case "julio":
                    n = 7;
                    break;
                case "agosto":
                    n = 8;
                    break;
                case "septiembre":
                    n = 9;
                    break;
                case "octubre":
                    n = 10;
                    break;
                case "noviembre":
                    n = 11;
                    break;
                case "diciembre":
                    n = 12;
                    break;
            }

            return n;
        }
    }
}
