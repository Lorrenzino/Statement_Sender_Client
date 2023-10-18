using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementViewTabl_Commands.chek
{
    class EventChangSelectedStat_Command : CommandBase
    {
        private ViewModelListStatement model;
        public EventChangSelectedStat_Command(ViewModelListStatement dat)
        {
            model= dat;
        }


        public override void Execute(object parameter)
        {
            
        }
    }
}
