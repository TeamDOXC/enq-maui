using doxc_maui_enqapp.ViewModels;

namespace doxc_maui_enqapp.Pages;

public partial class ProfileMgmt : ContentPage
{
    CompanyProfileViewModel _viewModel;
    private IEnqAppOpenAPIClient _enqAppOpenAPIClient;

    public CompanyProfileViewModel CompanyProfile => _viewModel;

    //   public ProfileMgmt(IEnqAppOpenAPIClient enqAppOpenAPIClient)
    //{
    //       InitializeComponent();
    //       _enqAppOpenAPIClient = enqAppOpenAPIClient;
    //       BindingContext = this;
    //   }


    //   protected async override void OnBindingContextChanged()
    //   {
    //       _viewModel = new CompanyProfileViewModel(_enqAppOpenAPIClient);
    //       await _viewModel.GetCompanyProfileAsync("");
    //       base.OnBindingContextChanged();
    //   }

    public ProfileMgmt(CompanyProfileViewModel companyProfileViewModel)
    {
        BindingContext = companyProfileViewModel;
        InitializeComponent();
    }
}