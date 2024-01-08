using Statement_Sender_Client.Model;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using Statement_Sender_Client.WorkWithData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementEditor_Commands
{
    class ReturnStatementE_Command : CommandBase
    {
        private ViewModelStatementEditor _view;
        public ReturnStatementE_Command(ViewModelStatementEditor view)
        {
            _view = view;
        }
        public override void Execute(object parameter)
        {
            //Statement newSt = new Statement(Current_user.Current, _view.Priority, _view.Type_problem, _view.Description, Convert.ToDateTime(_view.Date_start), _view.Status);

            User AC = new User();

            foreach (User U in Current_user.Users_accountable)
            {
                if (_view.Type_accountable.Contains(U.Department))
                    AC = U;
            }

            Statement newStatement = new Statement(Convert.ToInt32(_view.Autor_ID),
                                                    _view.Sender, AC, _view.Worker,
                                                    _view.Sender_Name, _view.Sender_Department, _view.Addres, _view.Room, _view.Phone_nom,
                                                    _view.Priority, _view.Type_problem, _view.Subject, _view.Description, _view.Rezult, null,
                                                    Convert.ToDateTime(_view.Date_start), Convert.ToDateTime(_view.Date_end), Convert.ToDateTime(_view.Date_control),
                                                    Current_user.Type_of_status[3]);
            ObservableCollection<Statement> s = new ObservableCollection<Statement>();
            s.Add(newStatement);
            List<User> lu = new List<User>();
            lu.Add(Current_user.Current);
            Request r = new Request("update", Current_user.LPK, s, lu);
            //ViewModelStatement newSVM = new ViewModelStatement(newStatement);
            //Statement_Collection.User_StatementsVM.Add(newSVM);
            Client A = new Client();
            A.OutCommingCallAsync(r);
        }
    }
}
