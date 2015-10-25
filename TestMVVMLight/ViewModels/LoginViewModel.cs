using GalaSoft.MvvmLight;
using TestMVVMLight.Services;

namespace TestMVVMLight.ViewModels
{
    public interface ILogin
    {
        string Username { get; set; }
        string Password { get; set; }
    }

    class LoginViewModel : ViewModelBase, ILogin
    {
        private readonly LoginService dataService = new LoginService();

        private string username = string.Empty;
        private string password = string.Empty;

        public string Username
        {
            get { return username; }
            set { Set(ref username, value); }
        }

        public string Password
        {
            get { return password; }
            set { Set(ref password, value); }
        }

        void Login()
        {
            dataService.Login(this);
        }
    }
}
