namespace AppFramework;

public partial class App : PrismApplication
{
    public App()
    {
        InitializeComponent();
    }

    protected override void OnInitialized()
    {
        AppSetting.OnInitialized();
        base.OnInitialized();
    }
}