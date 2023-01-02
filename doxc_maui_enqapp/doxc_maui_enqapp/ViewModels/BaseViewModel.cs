
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
