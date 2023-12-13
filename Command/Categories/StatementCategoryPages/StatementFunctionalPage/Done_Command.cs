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
    internal class Done_Command : CommandBase
    {
        private readonly NavigationLib _navigationLib;
        ObservableCollection<ViewModelStatement> Statement_list= new ObservableCollection<ViewModelStatement>();

        public Done_Command(NavigationLib lib, ObservableCollection<ViewModelStatement> _list)
        {
            _navigationLib = lib;
            /*
            foreach (ViewModelStatement st in _list)
            {
                if (st.Sender.User_ID == Current_user.Current.User_ID)
                    if (st.Status == "Завершена")
                    Statement_list.Add(st);
            }
            */
        }

        public override void Execute(object parameter)
        {
            Statement_list.Clear();
            foreach (ViewModelStatement st in Statement_Collection.User_StatementsVM)
            {
                if (st.Sender.User_ID == Current_user.Current.User_ID)
                    if (st.Status == "Завершена")
                        Statement_list.Add(st);
            }
            _navigationLib.CurPage_Statements = new ViewModelListStatement(_navigationLib, Statement_list);
            //_navigationLib.CurPage_Statements.Rfresh();
        }
    }
}
