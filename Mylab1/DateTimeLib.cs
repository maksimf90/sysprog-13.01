namespace Mylib
{
    namespace DateTimeLib
    {
        public class DateTimeFunctions
        {
            public static TimeSpan FindDateDifference(DateTime date1, DateTime date2)
            {
                return date2 - date1;
            }

            public static bool IsLeapYear(int year)
            {
                return DateTime.IsLeapYear(year);
            }

            public static string FindTimeOfDay(DateTime time)
            {
                if (time.Hour < 12)
                    return "Утро";
                else if (time.Hour < 18)
                    return "День";
                else
                    return "Вечер";
            }

            public static string FormatDateTime(DateTime dateTime)
            {
                return dateTime.ToString("dd.MM.yyyy HH:mm:ss");
            }
        }
    }
}
    