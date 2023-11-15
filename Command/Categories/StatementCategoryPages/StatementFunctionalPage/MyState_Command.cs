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

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage
{
    class MyState_Command : CommandBase
    {
        ViewModel_MainStatementPage VM_model;
        
        ObservableCollection<ViewModelStatement> Statement_list= new ObservableCollection<ViewModelStatement>();

        public MyState_Command(ViewModel_MainStatementPage _model, ObservableCollection<ViewModelStatement> _list) 
        {
            VM_model= _model;
            foreach (ViewModelStatement st in _list)
            {
                if (st.Sender.User_ID == Current_user.Current.User_ID)
                    Statement_list.Add(st);
            }
            
        }

        public override void Execute(object parameter)
        {
            //VM_model.ViewTabPage.DataContext = new ViewModelListStatement(Statement_list);
            VM_model.CurPage_StatementSub = VM_model.ViewTabPage;
            VM_model.ViewTabPage.DataContext = new ViewModelListStatement(Statement_list);
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
