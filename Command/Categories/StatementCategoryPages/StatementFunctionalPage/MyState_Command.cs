using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statement_Sender_Client.Navigation.Categories;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage
{
    class MyState_Command: CommandBase
    {
        public MyState_Command() 
        {
            
        }

        public override void Execute(object parameter)
        {
            NavigationLib._StatementSub.Open_ViewTabPage_X();


        }
    }
}
