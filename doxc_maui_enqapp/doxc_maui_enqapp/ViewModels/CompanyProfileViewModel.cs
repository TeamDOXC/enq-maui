using EnqApp.OpenAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doxc_maui_enqapp.ViewModels
{
    public class CompanyProfileViewModel : INotifyPropertyChanged
    {
        private IEnqAppOpenAPIClient _OpenAPIClient;

        public event PropertyChangedEventHandler PropertyChanged;
        public CompanyProfile CompanyProfile { get; private set; }

       

        public CompanyProfileViewModel(IEnqAppOpenAPIClient enqAppOpenAPIClient) 
        {  
            _OpenAPIClient = enqAppOpenAPIClient;
            GetCompanyProfileAsync("6350c54bee5c6eb08cefffba");
        }

        void GetCompanyProfileAsync(string Id)
        {
           CompanyProfile = _OpenAPIClient.Company_GetCompanyProfileByIdAsync(Id).GetAwaiter().GetResult();
        }
    }
}