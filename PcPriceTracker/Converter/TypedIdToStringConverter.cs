using PcPriceTracker.Domain.Abstractions;
using System.Globalization;
using System.Windows.Data;

namespace PcPriceTracker.Converter
{
    internal class TypedIdToStringConverter<T> : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Guid guid = ((TypedID<T>) value).ID;
            return guid.ToString().Substring(0,8)+"...";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
