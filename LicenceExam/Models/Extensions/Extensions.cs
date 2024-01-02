using System;
using System.Globalization;

namespace LicenceExam.Models.Extensions
{
    public static class Extensions
    {
        public static string ToPersianDate(this DateTime date)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            if (date == null || date == default)
            {
                return "";
            }
            string sal = persianCalendar.GetYear(date).ToString();
            string mah = persianCalendar.GetMonth(date).ToString();
            string ruz = persianCalendar.GetDayOfMonth(date).ToString();
            return sal + "/" + mah + "/" + ruz;
        }
    }
}