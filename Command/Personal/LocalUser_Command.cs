using Statement_Sender_Client.Model;
using Statement_Sender_Client.Navigation.Categories.StatementCategory;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.WorkWithData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Command.Personal
{
    internal class LocalUser_Command : CommandBase
    {
        private readonly NavigationLib _navigationLib;
        public LocalUser_Command(NavigationLib navigationLib)
        {
            _navigationLib = navigationLib;
        }
        public override void Execute(object parameter)
        {

            _navigationLib.CurPage_Statements = new ViewModelListStatement(_navigationLib, Statement_Collection.User_StatementsVM);
            
            if (!Current_user.isAutorise)
            {
                
                _navigationLib.CurPage_Main = new ViewModel_MainStatementPage(_navigationLib);
                _navigationLib.CurPage_Statements.Rfresh();
            }

        }
    }
}
