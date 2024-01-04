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
    internal class Test_Command : CommandBase
    {
        private readonly NavigationLib _navigationLib;
        ObservableCollection<ViewModelStatement> Statement_list =new ObservableCollection<ViewModelStatement>();

        public Test_Command(NavigationLib lib, ObservableCollection<ViewModelStatement> _list)
        {
            _navigationLib = lib;
            
        }

        public override void Execute(object parameter)
        {
            //Statement_list.Clear();
            //foreach (ViewModelStatement st in Statement_Collection.User_StatementsVM)
            //{
            //    if (st.Sender.User_ID == Current_user.Current.User_ID)
            //        if (st.Status == "Обробляється")
            //            Statement_list.Add(st);
            //}
            Statement_list.Clear();
            foreach (ViewModelStatement st in Statement_Collection.User_StatementsVM)
            {
                if (Current_user.isAutorise)
                {
                    if (st.Sender.User_ID == Current_user.Current.User_ID)
                        if (st.Status == Current_user.Type_of_status[2])
                            Statement_list.Add(st);
                }
                else
                {
                    if (st.Sender.User_pers_nom == Current_user.Current.User_pers_nom)
                        if (st.Status == Current_user.Type_of_status[2])
                            Statement_list.Add(st);
                }
            }
            _navigationLib.CurPage_Statements = new ViewModelListStatement(_navigationLib, Statement_list);
            _navigationLib.CurPage_Statements.Rfresh();
        }
    }
}
