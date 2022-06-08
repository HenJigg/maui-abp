using System.Globalization;

namespace AppFramework.Converters
{
    public class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            /*
             *  PI中返回国家语言由两部分组成
             *  [key](对应的国家名称) [value](对应的本地应用程序中的图标名)
             *
             *  故取第1位索引的值,再查找本地资源转换成图片(ImageSource)显示在UI当中
             */
            var val = value.ToString().Split(' ');
            return AssetsHelper.GetImageNamespace($"{val[1]}.png"); 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}