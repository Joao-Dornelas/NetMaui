namespace AppNavigationPage;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private void OnButtonClickedPage1(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    private void OnButtonClickedPage2(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}