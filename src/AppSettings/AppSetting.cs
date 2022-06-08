using AppFramework.Extensions;

namespace AppFramework
{
    public class AppSetting
    {
        private AppSetting()
        {
            this.currentTheme = App.Current.RequestedTheme;
            this.selectedPrimaryColor = this.currentTheme == AppTheme.Light ? 0 : 1;
        }

        static AppSetting()
        {
            Instance = new AppSetting();
        }

        public static AppSetting Instance { get; }

        private bool isDarkTheme;
        public bool IsDarkTheme
        {
            get => this.isDarkTheme;
            set
            {
                if (this.isDarkTheme == value)
                    return;

                this.isDarkTheme = value;
                if (this.isDarkTheme)
                    App.Current.Resources.ApplyDarkTheme();
                else
                    App.Current.Resources.ApplyLightTheme();
            }
        }

        private int selectedPrimaryColor;
        private readonly AppTheme currentTheme;

        public int SelectedPrimaryColor
        {
            get => this.selectedPrimaryColor;
            set
            {
                if (this.selectedPrimaryColor == value)
                    return;

                this.selectedPrimaryColor = value;
                ThemePalette.ApplyColorSet(this.selectedPrimaryColor);
            }
        }

        public static void OnInitialized()
        {
            AppTheme currentTheme = App.Current.RequestedTheme;
            if (currentTheme == AppTheme.Light)
                App.Current.Resources.ApplyLightTheme();
            else
                App.Current.Resources.ApplyDarkTheme();
        }
    }
}
