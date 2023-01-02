using EnqAppMAUI.Models.Auth;

namespace EnqAppMAUI.Services.Identity
{
    public class AuthService : IAuthService
    {
        public JwtTokenValues CreateAuthorizationRequest()
        {
            return new JwtTokenValues()
            {
                Username = "Prabhu Karthick",
                ProfileId = "Testing ProfileID"
            };
        }
    }
}
