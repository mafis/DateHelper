using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CodeIsCool.DateHelper
{
    public class DateToStringValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string returnValue;

            var dateTime = (DateTime) value;

            var secondDateTime =  parameter == null ? DateTime.Now : (DateTime)parameter;

            var timeSpan = secondDateTime.Subtract(dateTime);

            if (timeSpan.TotalSeconds < 60)
            {
                returnValue = String.Format("Vor {0} Sekunden", timeSpan.TotalSeconds);
            }
            else if (timeSpan.TotalMinutes < 60)
            {
                returnValue = String.Format("Vor {0} Minuten", timeSpan.TotalMinutes);
            }
            else if (timeSpan.TotalHours < 48)
            {
                returnValue = String.Format("Vor {0} Stunden", timeSpan.TotalHours);
            }
            else if (timeSpan.TotalDays < 28)
            {
                returnValue = String.Format("Vor {0} Tagen", timeSpan.TotalDays);
            }
            else
            {
                returnValue = "Vor sehr langer Zeit";
            }

            
            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
