using CommunityToolkit.Mvvm.Input;
using EnqApp.OpenAPI.Contracts;
using EnqAppMAUI.Services.User;
using System.Windows.Input;

namespace EnqAppMAUI.Services.MockService
{
    public class UserMockService : IUserService
    {
        public UserMockService()
        {
        }

        public async Task<PersonalProfile> GetUserInfoAsync(string authToken)
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync(@"MockData\CompanyProfile.json");
            using var reader = new StreamReader(stream);
            var content = await reader.ReadToEndAsync();
            CompanyProfile _companyProfile = CompanyProfile.FromJson(content);
            PersonalProfile personalProfile = _companyProfile.ContactPersonDetails;
            return await Task.FromResult(personalProfile);
        }
    }
}