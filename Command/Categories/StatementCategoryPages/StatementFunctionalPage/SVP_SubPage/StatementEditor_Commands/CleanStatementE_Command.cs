using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementEditor_Commands
{
    class CleanStatementE_Command : CommandBase
    {
        private ViewModelStatementEditor _view;

        public CleanStatementE_Command(ViewModelStatementEditor view)
        {
            _view = view;
        }
        public override void Execute(object parameter)
        {
            _view.Subject = "";
            _view.Description = "";
            _view.Type_problem = "";
            if (_view.IsChecked)
            {
                _view.Sender_Name = "";
                _view.Addres = "";
                _view.Sender_Department = "";
                _view.Room = "";
                _view.Phone_nom = "";
            }

        }
    }
}
