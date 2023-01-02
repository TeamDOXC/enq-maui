using CommunityToolkit.Mvvm.Input;
using EnqApp.OpenAPI.Contracts;
using EnqAppMAUI.Services.User;
using System.Windows.Input;

namespace EnqAppMAUI.ViewModels
{
    public class MainViewModel
    {
        private IUserService _userService;
        private PersonalProfile _profileUser;

        public MainViewModel(IUserService userService)
        {
            _userService = userService;
            SignInCommand = new AsyncRelayCommand<string>(GetUserInfoAsync);
        }

        private async Task GetUserInfoAsync(string arg)
        {
           _profileUser =  await _userService.GetUserInfoAsync(arg);
        }

        public ICommand SignInCommand { get; }
    }
}

