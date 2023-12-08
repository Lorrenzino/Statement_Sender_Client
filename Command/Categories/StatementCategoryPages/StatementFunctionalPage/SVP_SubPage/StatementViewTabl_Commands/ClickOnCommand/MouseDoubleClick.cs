using Statement_Sender_Client.Navigation.Categories.StatementCategory;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementViewTabl_Commands.ClickOnCommand
{
    class MouseDoubleClick : CommandBase
    {
        private readonly NavigationLib _navigationLib;
        private ViewModelListStatement _view;

        public MouseDoubleClick(NavigationLib lib, ViewModelListStatement view)
        {
            _navigationLib = lib;
            _view = view;
        }
        public override void Execute(object parameter)
        {

            _navigationLib.CurPage_Statements = new ViewModelStatementEditor(_view._Selected_item);

        }
    }
}
