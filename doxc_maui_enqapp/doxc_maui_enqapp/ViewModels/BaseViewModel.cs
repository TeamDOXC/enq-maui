using EnqApp.OpenAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doxc_maui_enqapp.ViewModels
{
    public class BaseViewModel
    {
        private readonly IEnqAppOpenAPIClient _enqOpenAPIClient;

        public BaseViewModel(IEnqAppOpenAPIClient enqAppOpenAPIClient)
        {
            _enqOpenAPIClient = enqAppOpenAPIClient;
        }

        public IEnqAppOpenAPIClient EnqOpenAPIClient => _enqOpenAPIClient;
    }
}
