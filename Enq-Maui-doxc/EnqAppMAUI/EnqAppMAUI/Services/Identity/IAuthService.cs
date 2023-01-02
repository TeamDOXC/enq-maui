using EnqAppMAUI.Models.Auth;

namespace EnqAppMAUI.Services.Identity
{
    public interface IAuthService
    {
        public JwtTokenValues CreateAuthorizationRequest();
    }
}
