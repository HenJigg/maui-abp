using System.Globalization;

namespace AppFramework.Services
{
    public partial class LocaleCulture
    {
        public partial CultureInfo GetCurrentCultureInfo()
        {
            return Thread.CurrentThread.CurrentUICulture;
        }

        public partial void SetLocale(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }
    }
}