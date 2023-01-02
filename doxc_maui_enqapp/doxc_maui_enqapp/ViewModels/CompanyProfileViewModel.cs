using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace doxc_maui_enqapp.ViewModels
{

    [QueryProperty(nameof(ProfileId), "ProfileId")]
    public partial class CompanyProfileViewModel:ObservableObject
    {
        private IEnqAppOpenAPIClient _OpenAPIClient;
        public string ProfileId { get; set; }

        private CompanyProfile _companyProfile;

        public string CompanyName {
            get => _companyProfile.Name;
            set => SetProperty(_companyProfile.Name, value, _companyProfile, (u,n)=> u.Name = n);
        }

        public CompanyProfile CompanyProfile {
            get => _companyProfile;
            set => SetProperty(ref _companyProfile, value);
        }

        //public string Sector
        //{
        //    get => _companyProfile.Sector;
        //    set => SetProperty(_companyProfile.Sector, value, _companyProfile, (u, n) => u.Sector = n);
        //}

        //public string Industry
        //{
        //    get => _companyProfile.Industry;
        //    set => SetProperty(_companyProfile.Industry, value, _companyProfile, (u, n) => u.Industry = n);
        //}

        //public string SubIndustry
        //{
        //    get => _companyProfile.Sub_Industry;
        //    set => SetProperty(_companyProfile.Sub_Industry, value, _companyProfile, (u, n) => u.Sub_Industry = n);
        //}

        //public DateTimeOffset IncorporateDate
        //{
        //    get => _companyProfile.IncorpatedDate;
        //    set => SetProperty(_companyProfile.IncorpatedDate, value, _companyProfile, (u, n) => u.IncorpatedDate = n);
        //}

        //public string Website
        //{
        //    get => _companyProfile.Website;
        //    set => SetProperty(_companyProfile.Website, value, _companyProfile, (u, n) => u.Website = n);
        //}

        //public int EmployeeCount
        //{
        //    get => _companyProfile.NoOfEmployee;
        //    set => SetProperty(_companyProfile.NoOfEmployee, value, _companyProfile, (u, n) => u.NoOfEmployee = n);
        //}

        public CompanyProfileViewModel(IEnqAppOpenAPIClient enqAppOpenAPIClient) 
        {  
            _OpenAPIClient = enqAppOpenAPIClient;
        }

        public async Task GetCompanyProfileAsync(string Id)
        {
#if DEBUG
            using var stream = await FileSystem.OpenAppPackageFileAsync("Profile-Company.json");
            using var reader = new StreamReader(stream);
            var content = await reader.ReadToEndAsync();
            _companyProfile =  CompanyProfile.FromJson(content);
#else
            _companyProfile = _OpenAPIClient.Company_GetCompanyProfileByIdAsync(Id).GetAwaiter().GetResult();
#endif
        }
    }
}