using AppFramework.Themes;

namespace AppFramework.Extensions
{
    public static class ThemePalette
    {
        public static void ApplyDarkTheme(this ResourceDictionary resources)
        {
            if (resources != null)
            {
                var mergedDictionaries = resources.MergedDictionaries;

                var lightTheme = mergedDictionaries.OfType<LightTheme>().FirstOrDefault();
                if (lightTheme != null)
                {
                    mergedDictionaries.Remove(lightTheme);
                }

                mergedDictionaries.Add(new DarkTheme());
                AppSetting.Instance.IsDarkTheme = true; 
                AppSetting.Instance.SelectedPrimaryColor = 1;
            }
        }

        public static void ApplyLightTheme(this ResourceDictionary resources)
        {
            if (resources != null)
            {
                var mergedDictionaries = resources.MergedDictionaries;

                var darkTheme = mergedDictionaries.OfType<DarkTheme>().FirstOrDefault();
                if (darkTheme != null)
                {
                    mergedDictionaries.Remove(darkTheme);
                }

                mergedDictionaries.Add(new LightTheme());
                AppSetting.Instance.IsDarkTheme = false; 
                AppSetting.Instance.SelectedPrimaryColor = 0;
            }
        }

        public static void ApplyColorSet(int index)
        {
            switch (index)
            {
                case 0:
                    ApplyColorSet1();
                    break;

                case 1:
                    ApplyColorSet2();
                    break;

                case 2:
                    ApplyColorSet3();
                    break;

                case 3:
                    ApplyColorSet4();
                    break;

                case 4:
                    ApplyColorSet5();
                    break;
            }
        }

        public static void ApplyColorSet1()
        {
            App.Current.Resources["PrimaryColor"] = Color.FromArgb("#f54e5e");
            App.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#d0424f");
            App.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#ab3641");
            App.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#edcacd");
            App.Current.Resources["PrimaryLight"] = Color.FromArgb("#ffe8f4");
            App.Current.Resources["PrimaryGradient"] = Color.FromArgb("e83f94");
        }

        public static void ApplyColorSet2()
        {
            if (AppSetting.Instance.IsDarkTheme)
            {
                App.Current.Resources["PrimaryColor"] = Color.FromArgb("#42A1FF");
                App.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#0F88FF");
                App.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#006EDB");
                App.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#75BAFF");
                App.Current.Resources["PrimaryLight"] = Color.FromArgb("#A8D4FF");
                App.Current.Resources["PrimaryGradient"] = Color.FromArgb("#0080FF");
            }
            else
            {
                App.Current.Resources["PrimaryColor"] = Color.FromArgb("#2f72e4");
                App.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#1a5ac6");
                App.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#174fb0");
                App.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#73a0ed");
                App.Current.Resources["PrimaryLight"] = Color.FromArgb("#cdddf9");
                App.Current.Resources["PrimaryGradient"] = Color.FromArgb("#00acff");
            }
        }

        public static void ApplyColorSet3()
        {
            if (AppSetting.Instance.IsDarkTheme)
            {
                App.Current.Resources["PrimaryColor"] = Color.FromArgb("#D88AFF");
                App.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#9E63BC");
                App.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#804A9B");
                App.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#D49FEE");
                App.Current.Resources["PrimaryLight"] = Color.FromArgb("#D4B6E3");
                App.Current.Resources["PrimaryGradient"] = Color.FromArgb("#6C58FF");
            }
            else
            {
                App.Current.Resources["PrimaryColor"] = Color.FromArgb("#5d4cf7");
                App.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#4b3ae1");
                App.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#3829ba");
                App.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#b5aefb");
                App.Current.Resources["PrimaryLight"] = Color.FromArgb("#eae8fe");
                App.Current.Resources["PrimaryGradient"] = Color.FromArgb("#aa9cfc");
            }
        }

        public static void ApplyColorSet4()
        {
            if (AppSetting.Instance.IsDarkTheme)
            {
                App.Current.Resources["PrimaryColor"] = Color.FromArgb("#17B0A8");
                App.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#11837D");
                App.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#0B5652");
                App.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#8AF0EA");
                App.Current.Resources["PrimaryLight"] = Color.FromArgb("#CDF9F6");
                App.Current.Resources["PrimaryGradient"] = Color.FromArgb("#A5FEB2");
            }
            else
            {
                App.Current.Resources["PrimaryColor"] = Color.FromArgb("#06846a");
                App.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#056c56");
                App.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#045343");
                App.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#98f0de");
                App.Current.Resources["PrimaryLight"] = Color.FromArgb("#ebf9f7");
                App.Current.Resources["PrimaryGradient"] = Color.FromArgb("#0ed342");
            }
        }

        public static void ApplyColorSet5()
        {
            if (AppSetting.Instance.IsDarkTheme)
            {
                App.Current.Resources["PrimaryColor"] = Color.FromArgb("#FF668C");
                App.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#C83A62");
                App.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#882742 ");
                App.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#FF9FBA");
                App.Current.Resources["PrimaryLight"] = Color.FromArgb("#FAC7D5");
                App.Current.Resources["PrimaryGradient"] = Color.FromArgb("#FFBF9F");
            }
            else
            {
                App.Current.Resources["PrimaryColor"] = Color.FromArgb("#d54008");
                App.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#a43106");
                App.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#862805");
                App.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#fa9e7c");
                App.Current.Resources["PrimaryLight"] = Color.FromArgb("#fee7de");
                App.Current.Resources["PrimaryGradient"] = Color.FromArgb("#ff6374");
            }
        }
    }
}
