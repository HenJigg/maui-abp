namespace AppFramework
{
    public static class AssetsHelper
    { 
        public static string ProfileImagePlaceholderNamespace => GetImageNamespace("Person.png");

        public static string GetImageNamespace(string fileName)
        {
            return string.Format("{0}", fileName);
        }
    }
}