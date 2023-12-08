using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementEditor_Commands.ManageButton
{
    internal class DeleteStatementMB_Command : CommandBase
    {
        private ViewModelStatement _statement;
        private ViewModelListStatement _vm;

        public DeleteStatementMB_Command(ViewModelStatement statement, ViewModelListStatement vm)
        {
            _statement = vm.IsSelectedRow;
            _vm = vm;
        }
        public override void Execute(object parameter)
        {
            foreach(ViewModelStatement st in _vm.statement_list)
            {
                if(st==_statement)
                {
                    _vm.statement_list.Remove(st);
                }
            }

        }

    }
}
