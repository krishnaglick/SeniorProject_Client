
using GalaSoft.MvvmLight;
using TestMVVMLight.Services;

namespace TestMVVMLight.ViewModel
{
    public interface ILogin
    {
        string Username { get; set; }
        string Password { get; set; }
    }

    class LoginViewModel : ViewModelBase, ILogin
    {
        private LoginService dataService;

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

        public LoginViewModel(ILoginService ds)
        {
            this.dataService = ds as LoginService;
        }

        void Login()
        {
            dataService.Login(this);
        }
    }
}
