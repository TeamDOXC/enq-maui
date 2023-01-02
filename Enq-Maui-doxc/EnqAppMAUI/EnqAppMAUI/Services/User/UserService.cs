using EnqApp.OpenAPI.Contracts;

namespace EnqAppMAUI.Services.User
{
    public class UserService : IUserService
    {
        public Task<PersonalProfile> GetUserInfoAsync(string authToken)
        {
            throw new NotImplementedException();
        }
    }
}
