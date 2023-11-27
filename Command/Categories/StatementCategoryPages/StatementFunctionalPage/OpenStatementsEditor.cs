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

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage
{
    internal class OpenStatementsEditor: CommandBase
    {
       
            private readonly NavigationLib _navigationLib;
            ObservableCollection<ViewModelStatement> Statement_list = new ObservableCollection<ViewModelStatement>();

            public OpenStatementsEditor(NavigationLib lib)
            {
                _navigationLib = lib;
            
            }

            public override void Execute(object parameter)
            {
                _navigationLib.CurPage_Statements = new ViewModelStatementEditor();
                _navigationLib.CurPage_Statements.Rfresh();
            }
        
    }
}