using LF10_Project.MVVM.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace LF10_Project.Resources.Converters
{
	class StringToAbbreviationConverter : IValueConverter
	{
		public StringToAbbreviationConverter ()
		{

		}

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is string name)
            {
                return name.Length >= 3 ? name.Substring(0, 3) : name;
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}