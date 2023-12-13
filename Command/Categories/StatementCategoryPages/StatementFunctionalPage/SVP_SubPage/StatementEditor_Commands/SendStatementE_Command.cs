using Statement_Sender_Client.Model;
using Statement_Sender_Client.ViewModel.Categories.Statements;
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
    class SendStatementE_Command : CommandBase
    {
        private ViewModelStatementEditor _view;

        public SendStatementE_Command(ViewModelStatementEditor view)
        {
            _view = view;
        }
        public override void Execute(object parameter)
        {
            //Statement newSt = new Statement(Current_user.Current, _view.Priority, _view.Type_problem, _view.Description, Convert.ToDateTime(_view.Date_start), _view.Status);
            Statement newStatement = new Statement( 0,
                                                    Current_user.Current, null,null,
                                                    _view.Sender_Name, _view.Sender_Department, _view.Addres, _view.Room, _view.Phone_nom, 
                                                    _view.Priority, _view.Type_problem, _view.Subject, _view.Description, null,null,
                                                    Convert.ToDateTime(_view.Date_start),DateTime.MinValue, DateTime.MinValue,
                                                    _view.Status);
            ObservableCollection<Statement> s = new ObservableCollection<Statement>();
            s.Add(newStatement);
            Request r = new Request("insert", Current_user.LPK, s);
            //ViewModelStatement newSVM = new ViewModelStatement(newStatement);
            //Statement_Collection.User_StatementsVM.Add(newSVM);
            Client A = new Client();
            A.OutCommingCallAsync(r);
        }
    }
}


