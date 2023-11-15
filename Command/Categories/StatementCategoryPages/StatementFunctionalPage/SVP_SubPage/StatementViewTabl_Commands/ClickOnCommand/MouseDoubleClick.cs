using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementViewTabl_Commands.ClickOnCommand
{
    class MouseDoubleClick : CommandBase
    {
        private ViewModelListStatement _view;

        public MouseDoubleClick(ViewModelListStatement Selected_item)
        {
            _view = Selected_item;
        }
        public override void Execute(object parameter)
        {
            
            

        }
    }
}
