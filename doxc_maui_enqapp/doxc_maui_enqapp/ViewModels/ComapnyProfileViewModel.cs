using EnqApp.OpenAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doxc_maui_enqapp.ViewModels
{
    public class CompanyProfileViewModel : CompanyProfile, INotifyPropertyChanged
    {
        private IEnqAppOpenAPIClient _OpenAPIClient;

        public event PropertyChangedEventHandler PropertyChanged;

        public string LabelText { get; set; } = "Hello World..... &&&&&&&&&&&&&&&&&&&";
        public CompanyProfileViewModel()
        {
            //_OpenAPIClient = enqAppOpenAPIClient;
        }
    }
}
