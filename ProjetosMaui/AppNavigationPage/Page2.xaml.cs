namespace AppNavigationPage;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void OnButtonClickedPage1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void OnButtonClickedPage3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page3());
    }
}