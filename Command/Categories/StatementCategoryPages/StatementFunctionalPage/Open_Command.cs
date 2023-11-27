using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statement_Sender_Client.Model;
using Statement_Sender_Client.Navigation.Categories.StatementCategory;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage
{
    internal class Open_Command : CommandBase
    {
        private readonly NavigationLib _navigationLib;
        ObservableCollection<ViewModelStatement> Statement_list= new ObservableCollection<ViewModelStatement>();

        public Open_Command(NavigationLib lib, ObservableCollection<ViewModelStatement> _list)
        {
            _navigationLib = lib;
            foreach (ViewModelStatement st in _list)
            {
                if (st.Sender.User_ID == Current_user.Current.User_ID)
                    if(st.Status == "Відкрита")
                        Statement_list.Add(st);
            }
        }

        public override void Execute(object parameter)
        {
            _navigationLib.CurPage_Statements = new ViewModelListStatement(_navigationLib, Statement_list);
            _navigationLib.CurPage_Statements.Rfresh();
        }
    }
}
