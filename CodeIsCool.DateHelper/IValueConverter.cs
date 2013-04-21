using System;
using System.Globalization;

namespace CodeIsCool.DateHelper
{

	public interface IValueConverter
	{
		object Convert(object value, Type targetType, object parameter, CultureInfo culture);
		object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
	}
}
