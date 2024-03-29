using System;
using System.Globalization;
using System.Windows.Data;

namespace App
{
    public class HeightToTextConverter : Singleton<HeightToTextConverter> , IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is double)
            {
                return string.Format("Double value are {0}", (double) value);
            }
            return "Not double value";
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}