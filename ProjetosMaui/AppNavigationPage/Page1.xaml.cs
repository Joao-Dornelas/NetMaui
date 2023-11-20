namespace AppNavigationPage;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void OnButtonClickedPage2(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page2() );
    }

    private void OnButtonClickedPage3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page3());
        //Cria a pagina 2 na pilha antes da página 3
        Navigation.InsertPageBefore(new Page2(), Navigation.NavigationStack[1]);
    }
}