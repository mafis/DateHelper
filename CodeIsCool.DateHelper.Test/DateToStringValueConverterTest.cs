using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeIsCool.DateHelper.Test
{
    [TestFixture]
    public class DateToStringValueConverterTest
    {
        [TestCaseSource(typeof(DateToStringValueConverterTest), "DateValuesData")]
        public string ConvertDateTimeToString(DateTime dateTime, DateTime secondDate)
        {
            var dateToStringValueConverter = new DateToStringValueConverter();

            return (String)dateToStringValueConverter.Convert(dateTime, typeof (String), secondDate, null);
        }

        private static IEnumerable DateValuesData()
        {
            var dateTime = new DateTime(2013,01,01);

            yield return new TestCaseData(dateTime, dateTime.AddSeconds(5)).Returns("Vor 5 Sekunden");
            yield return new TestCaseData(dateTime, dateTime.AddMinutes(30)).Returns("Vor 30 Minuten");
            yield return new TestCaseData(dateTime, dateTime.AddHours(6)).Returns("Vor 6 Stunden");
            yield return new TestCaseData(dateTime, dateTime.AddHours(36)).Returns("Vor 36 Stunden");
            yield return new TestCaseData(dateTime, dateTime.AddDays(14)).Returns("Vor 14 Tagen");
            yield return new TestCaseData(dateTime, dateTime.AddDays(28)).Returns("Vor sehr langer Zeit");
        }
    }
}
