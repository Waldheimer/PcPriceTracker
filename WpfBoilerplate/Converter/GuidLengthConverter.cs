using System.Globalization;
using System.Windows.Data;

namespace WpfBoilerplate.Converter
{
    //  *********************************************************************************
    //  Converter to trim the length of a Guid to its first 8 characters followed by ...
    //  *********************************************************************************

    public class GuidLengthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Guid guid = (Guid)value;
            return guid.ToString().Substring(0, 8) + "...";
        }
        //  No ConvertBack needed
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
