using LF10_Project.MVVM.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace LF10_Project.Resources.Converters
{
    class SubjectTypeToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SubjectType subjectType)
            {
                if(subjectType == SubjectType.Empty || subjectType == SubjectType.Break || subjectType == SubjectType.LongBreak)
                {
                    return Visibility.Hidden;
                }

                return Visibility.Visible;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
