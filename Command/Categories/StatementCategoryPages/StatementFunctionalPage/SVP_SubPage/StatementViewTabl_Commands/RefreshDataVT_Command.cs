using Statement_Sender_Client.Model;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
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
        private ViewModelListStatement view;
        public RefreshDataVT_Command(ViewModelListStatement _view)
        {
            view = _view;
        }
        public override void Execute(object parameter)
        {
            string[] lp1 = new string[] { Current_user.LPK[0], Current_user.LPK[1],"",view.Select }; // тут данніе логин пароль.
            ObservableCollection<Statement> col = new ObservableCollection<Statement>();
            Statement a = new Statement(0,
                                                    Current_user.Current, null, null,
                                                    "", "", "", "", "",
                                                    "", "", "", "", null, null,
                                                    DateTime.MinValue, DateTime.MinValue, DateTime.MinValue,
                                                    "");
            col.Add(a);
            Request RE = new Request("select", lp1, col);
            Client A = new Client();
            A.OutCommingCallAsync(RE);
        }
    }
}
