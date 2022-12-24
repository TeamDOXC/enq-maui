using EnqApp.OpenAPI;

namespace doxc_maui_enqapp;

public partial class MainPage : ContentPage
{
	int count = 0;
	private IEnqAppOpenAPIClient _openAPI;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

