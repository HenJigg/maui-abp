namespace AppFramework.Views;

public partial class MainView : ContentView
{
    public MainView(IMessenger messenger)
    {
        InitializeComponent();
        messenger.Sub(AppMessengerKeys.RefreshUI, () =>
        {
            App.Current.Resources.TryGetValue("GrayShadowBackgroundColor", out var GrayShadowColor);
            this.BackgroundColor = (Color)GrayShadowColor; 
        });
    }
}