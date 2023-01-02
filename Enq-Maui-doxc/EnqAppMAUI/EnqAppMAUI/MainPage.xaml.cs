using EnqAppMAUI.ViewModels;

namespace EnqAppMAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainViewModel mainViewModel)
	{
		BindingContext = mainViewModel;
		InitializeComponent();
	}


    private void OnAuthBtnClicked(object sender, EventArgs e)
	{ 
        SemanticScreenReader.Announce(MockAuthBtn.Text);
    }
}

