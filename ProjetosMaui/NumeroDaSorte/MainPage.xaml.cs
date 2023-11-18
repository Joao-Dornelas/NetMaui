namespace NumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateNumbers(object sender, EventArgs e)
	{
        var numbers                     = GenerateNumbers();        
        Number0.Text                    = numbers.ElementAt(0).ToString("D2");
        Number1.Text                    = numbers.ElementAt(1).ToString("D2");
        Number2.Text                    = numbers.ElementAt(2).ToString("D2");
        Number3.Text                    = numbers.ElementAt(3).ToString("D2");
        Number4.Text                    = numbers.ElementAt(4).ToString("D2");
        Number5.Text                    = numbers.ElementAt(5).ToString("D2");

        if (NameApp.IsVisible)
        {
            NameApp.IsVisible           = false;
            NumbersContainer.IsVisible  = true;
            button.Text                 = "Gerar novo número";
        }
        else
        {
            Phrase.Text                 = "Seu novo Número da Sorte é:";
        }
    }
    private SortedSet<int> GenerateNumbers()
    {        
        var setNumbers                  = new SortedSet<int>(); // SortedSet -> nao deixa os numeros se repetirem e ordena eles
        while (setNumbers.Count < 6)
        {
            var random                  = new Random();
            var sortedNumber            = random.Next(1, 60);
            setNumbers.Add(sortedNumber);
        }

        return setNumbers;
    }
}