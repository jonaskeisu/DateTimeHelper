﻿using System;

namespace DateTimeHelperLib
{
    public static class DateTimeHelper
    {
        public static DateTime FirstInMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime LastInMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }
    }
}
