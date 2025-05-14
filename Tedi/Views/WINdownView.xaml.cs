namespace Tedi.Views;

public partial class WINdownView : ContentView
{
    public WINdownView()
    {
        InitializeComponent();
    }

    private async void OnContinueClicked(object sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Continue", "Simulating boot to desktop...", "OK");
    }

    private void OnTroubleshootClicked(object sender, EventArgs e)
{
    // Replace this view's content with TroubleshootView
    this.Content = new TroubleshootView();
}


    private async void OnPowerOffClicked(object sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Shutdown", "Pretending to shut down the PC...", "OK");
    }
}
