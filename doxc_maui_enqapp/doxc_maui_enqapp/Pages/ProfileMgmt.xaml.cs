using doxc_maui_enqapp.ViewModels;
using EnqApp.OpenAPI;

namespace doxc_maui_enqapp.Pages;

public partial class ProfileMgmt : ContentPage
{
    private CompanyProfileViewModel _viewModel;

    public ProfileMgmt(IEnqAppOpenAPIClient enqAppOpenAPIClient)
	{
        InitializeComponent();
        _viewModel = new CompanyProfileViewModel(enqAppOpenAPIClient);
        BindingContext = this;
    }

    public CompanyProfileViewModel  ProfileModel { get => _viewModel; set => _viewModel = value; }
}