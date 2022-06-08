namespace AppFramework.Helpers
{
    public class AppConfig
    {
        public static bool Desktop
        {
            get
            {
#if WINDOWS || MACCATALYST
            return true;
#else
                return false;
#endif
            }
        }
    }
}