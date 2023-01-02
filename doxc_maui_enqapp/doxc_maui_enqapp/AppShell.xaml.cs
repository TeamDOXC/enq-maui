using doxc_maui_enqapp.Pages;

namespace doxc_maui_enqapp;

public partial class AppShell : Shell
{
	public AppShell()
	{        
        InitializeComponent();
        Routing.RegisterRoute("ProfileMgmt", typeof(ProfileMgmt));
    }
}
