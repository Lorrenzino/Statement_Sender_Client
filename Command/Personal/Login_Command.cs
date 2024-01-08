using Statement_Sender_Client.Model;
using Statement_Sender_Client.Navigation.Categories.StatementCategory;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statement_Sender_Client.ViewModel.Categories.Personal;
using Statement_Sender_Client.WorkWithData;

namespace Statement_Sender_Client.Command.Personal
{
    internal class Login_Command : CommandBase
    {
        private readonly NavigationLib _navigationLib;
        private  ViewModel_Login login_vm;

        public Login_Command(NavigationLib lib, ViewModel_Login logpas)
        {
            _navigationLib = lib;
            login_vm = logpas;
        }

        public override void Execute(object parameter)
        {
            
            _navigationLib.CurPage_Statements = new ViewModelListStatement(_navigationLib,Statement_Collection.User_StatementsVM);
            Request r = new Request("login", new string[]{ login_vm.username, login_vm.password, "" }, null, null);
            //ViewModelStatement newSVM = new ViewModelStatement(newStatement);
            //Statement_Collection.User_StatementsVM.Add(newSVM);
            Client A = new Client();
            A.OutCommingCallAsync(r);
            r.Type_R = "users_accountable";
            A.OutCommingCallAsync(r);
            foreach(User u in Current_user.Users_accountable)
            {
                Current_user.Users_accountable_list.Add($"{u.Department}" + " " + $"{u.User_Name_Last}" + " " + $"{u.User_Name_First}");
            }
            if (Current_user.isAutorise)
            {
                _navigationLib.CurPage_Main = new ViewModel_MainStatementPage(_navigationLib);
                _navigationLib.CurPage_Statements.Rfresh();
            }
            
        }
    }
}
