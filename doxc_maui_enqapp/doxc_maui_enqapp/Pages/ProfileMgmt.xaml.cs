using doxc_maui_enqapp.ViewModels;

namespace doxc_maui_enqapp.Pages;

public partial class ProfileMgmt : ContentPage
{
    private CompanyProfileViewModel _viewModel;

    public ProfileMgmt(CompanyProfileViewModel viewModel)
	{

        InitializeComponent();
        this.BindingContext = viewModel;

    }
}