namespace Tedi.Views;

public partial class AdvancedOptionsView : ContentView
{
    public AdvancedOptionsView()
    {
        InitializeComponent();
    }

    private async void OnStartupRepairClicked(object sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Startup Repair", "Pretending to run diagnostics...", "OK");
    }

    private async void OnStartupSettingsClicked(object sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Startup Settings", "Options like Safe Mode will appear here.", "OK");
    }

    private async void OnCommandPromptClicked(object sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Command Prompt", "Imagine you're typing into a terminal now.", "OK");
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        // Go back to Troubleshoot view
        var parent = this.Parent as ContentView;
        if (parent != null)
            parent.Content = new TroubleshootView(); // Replace with the previous view
    }
}
