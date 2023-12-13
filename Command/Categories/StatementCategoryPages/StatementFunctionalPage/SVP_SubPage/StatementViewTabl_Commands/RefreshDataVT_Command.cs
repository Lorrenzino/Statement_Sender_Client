using Statement_Sender_Client.Model;
using Statement_Sender_Client.WorkWithData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementViewTabl_Commands
{
    internal class RefreshDataVT_Command : CommandBase
    {
        public RefreshDataVT_Command()
        {

        }
        public override void Execute(object parameter)
        {
            string[] lp1 = new string[] { "user", "user" }; // тут данніе логин пароль.
            ObservableCollection<Statement> col = null;
            Request RE = new Request("select", lp1, col);
            Client A = new Client();
            A.OutCommingCallAsync(RE);
        }
    }
}
