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

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage
{
    class MyState_Command: CommandBase
    {
        ViewModel_MainStatementPage VM_model;
        ObservableCollection<ViewModelStatement> Statement_list;

        public MyState_Command(ViewModel_MainStatementPage _model, ObservableCollection<ViewModelStatement> _list) 
        {
            VM_model= _model;
            Statement_list= _list;
        }

        public override void Execute(object parameter)
        {
            VM_model.ViewTabPage.DataContext = new ViewModelListStatement(Statement_list);
            //OnPropertyChanged();

        }
    }
}
