namespace Tedi.Views;

public partial class TroubleshootView : ContentView
{
    public TroubleshootView()
    {
        InitializeComponent();
    }

    private async void OnResetClicked(object sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Reset this PC", "Simulating reset options...", "OK");
    }

    private async void OnAdvancedClicked(object sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Advanced options", "Next view coming soon!", "OK");
    }
}
