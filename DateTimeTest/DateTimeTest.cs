using Mylib.DateTimeLib;
using NUnit.Framework;
namespace DateTimeTest
{
    public class DateTimeFunctionsTests
    {
        [Test]
        public void FindDateDifference_ShouldReturnCorrectDifference()
        {
            DateTime dateTime1 = new DateTime(2022, 1, 1);
            DateTime dateTime2 = new DateTime(2022, 1, 5);

            TimeSpan result = DateTimeFunctions.FindDateDifference(dateTime1, dateTime2);

            Assert.AreEqual(4, result.TotalDays);
        }

        [Test]
        public void IsLeapYear_ShouldReturnTrueForLeapYear()
        {
            int leapYear = 2024;

            bool result = DateTimeFunctions.IsLeapYear(leapYear);

            Assert.IsTrue(result);
        }

        [Test]
        public void FindTimeOfDay_ShouldReturnCorrectTimeOfDay()
        {
            DateTime morningTime = new DateTime(2022, 1, 1, 9, 0, 0);

            string result = DateTimeFunctions.FindTimeOfDay(morningTime);

            Assert.AreEqual("Утро", result);
        }

        [Test]
        public void FormatDateTime_ShouldReturnFormattedString()
        {
            DateTime dateTime = new DateTime(2022, 1, 1, 14, 30, 0);

            string result = DateTimeFunctions.FormatDateTime(dateTime);

            Assert.AreEqual("01.01.2022 14:30:00", result);
        }
    }
}