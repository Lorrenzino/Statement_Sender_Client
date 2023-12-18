using Statement_Sender_Client.Command.Personal;
using Statement_Sender_Client.Navigation.Categories.StatementCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Statement_Sender_Client.ViewModel.Categories.Personal
{
    internal class ViewModel_Login : ViewModelBase
    {
        private readonly NavigationLib _navigationLib;

        private string _username;
        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(username));
            }
        }

        private string _password;
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(password));
            }
        }

        public ICommand Login { get; }
        public ICommand LoginGest { get; }
        
        public ViewModel_Login(NavigationLib navigationLib)
        {
            _navigationLib = navigationLib;
            Login= new Login_Command(_navigationLib,this);
            
        }
    }
}
