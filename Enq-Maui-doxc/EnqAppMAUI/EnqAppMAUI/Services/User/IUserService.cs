using EnqApp.OpenAPI.Contracts;

namespace EnqAppMAUI.Services.User
{
    public interface IUserService
    {
        public Task<PersonalProfile> GetUserInfoAsync(string authToken);
    }
}
