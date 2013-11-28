﻿using System;
using Windows.UI.Xaml.Data;

namespace VLC_WINRT.Utility.Converters
{
    public class TimeSpanSecondsDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            TimeSpan span = (TimeSpan) value;
            return span.TotalSeconds;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}