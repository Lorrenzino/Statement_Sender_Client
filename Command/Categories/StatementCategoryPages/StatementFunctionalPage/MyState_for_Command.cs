using Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statement_Sender_Client.ViewModel;
using Statement_Sender_Client.Model;
using Statement_Sender_Client.Navigation.Categories.StatementCategory;
using Statement_Sender_Client.WorkWithData;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage
{
    class MyState_for_Command : CommandBase
    {
        private readonly NavigationLib _navigationLib;

        ObservableCollection<ViewModelStatement> Statement_list= new ObservableCollection<ViewModelStatement>();

        public MyState_for_Command(NavigationLib lib, ObservableCollection<ViewModelStatement> _list) 
        {
            _navigationLib = lib;
            /*
            foreach (ViewModelStatement st in _list)
            {
                if (st.Sender.User_ID == Current_user.Current.User_ID)
                    Statement_list.Add(st);
            }
            */
        }

        public override void Execute(object parameter)
        {
            Statement_list.Clear();
            foreach (ViewModelStatement st in Statement_Collection.User_StatementsVM)
            {
                if (Current_user.isAutorise)
                {
                    if (st.Worker.User_ID == Current_user.Current.User_ID)
                        Statement_list.Add(st);
                }
                else
                {
                    if (st.Worker.User_pers_nom == Current_user.Current.User_pers_nom)
                        Statement_list.Add(st);
                }
            }
            _navigationLib.CurPage_Statements = new ViewModelListStatement(_navigationLib, Statement_list);
            //_navigationLib.CurPage_Statements.PropertyChanged;
            //_navigationLib.CurPage_Statements.Rfresh();
            //VM_model.ViewTabPage.DataContext = new ViewModelListStatement(Statement_list);
            ////        VM_model.CurPage_StatementSub = VM_model.ViewTabPage;
            ////        VM_model.ViewTabPage.DataContext = new ViewModelListStatement(Statement_list);
            //VM_model._CurPage_StatementSub = VM_model.ViewTabPage;
            //OnPropertyChanged();

        }
        /*
        public MyState_Command(ViewModel_MainStatementPage model, ObservableCollection<ViewModelStatement> dat)
        {
            model.ViewTabPage.DataContext = new ViewModelListStatement(dat);
        }
        */
    }
}
