using System.Globalization;
using System.Windows.Data;

namespace WpfBoilerplate.Converter
{
    //  *********************************************************************************
    //  Converter to trim the length of a Guid to its first 8 characters followed by ...
    //  *********************************************************************************

    public class GuidLengthConverter : IValueConverter
    {
        //  *************************************
        //  Convert the Guid to a 8 char String followed by ... to reduce GUI space
        //  *************************************
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
