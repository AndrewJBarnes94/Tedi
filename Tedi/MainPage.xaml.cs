using Tedi.Views;

namespace Tedi;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnWINdownClicked(object sender, EventArgs e)
    {
        MainContent.Content = new WINdownView();
    }

    private void OnParsecutorClicked(object sendor, EventArgs e)
    {
        MainContent.Content = new ParsecutorView();
    }
}
