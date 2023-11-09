using Statement_Sender_Client.Model;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementEditor_Commands
{
    class SendStatementE_Command : CommandBase
    {
        private ViewModelStatementEditor _view;

        public SendStatementE_Command(ViewModelStatementEditor view)
        {
            _view = view;
        }
        public override void Execute(object parameter)
        {
            Statement newSt = new Statement(Current_user.Current, _view.Priority, _view.Type_problem, _view.Description, Convert.ToDateTime(_view.Date_start), _view.Status);
            ViewModelStatement newSVM = new ViewModelStatement(newSt);

        }
    }
}
