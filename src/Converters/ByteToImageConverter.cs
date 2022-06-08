using System.Globalization;

namespace AppFramework.Converters
{
    public class ByteToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            var profilePictureBytes = value as byte[];
            return ImageSource.FromStream(() => new MemoryStream(profilePictureBytes));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}