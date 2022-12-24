namespace doxc_maui_enqapp;

public partial class App : Application
{
	public App(MainPage mainPage)
	{
		InitializeComponent();

		MainPage = new AppShell();
		
	}
}
