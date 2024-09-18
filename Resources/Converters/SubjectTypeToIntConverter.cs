﻿using LF10_Project.MVVM.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LF10_Project.Resources.Converters
{
    class SubjectTypeToIntConverter : IValueConverter
    {
        const int EmptyTypeValue = 45;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SubjectType subjectType)
            {
                return (subjectType == SubjectType.Empty) ? EmptyTypeValue : (int) subjectType;
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
