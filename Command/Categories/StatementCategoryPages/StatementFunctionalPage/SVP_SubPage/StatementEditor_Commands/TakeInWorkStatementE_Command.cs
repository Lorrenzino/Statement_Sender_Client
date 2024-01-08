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
    class TakeInWorkStatementE_Command : CommandBase
    {
        private ViewModelStatementEditor _view;

        public TakeInWorkStatementE_Command(ViewModelStatementEditor view)
        {
            _view = view;
        }
        public override bool CanExecute(object parameter)
        {/*
            if(Current_user.Current.User_ID == _view.Accountable.User_ID) 
                return false;
            */
            return true;
        }
        public override void Execute(object parameter)
        {
            Statement newStatement = new Statement(Convert.ToInt32(_view.Autor_ID),
                                                    _view.Sender, _view.Accountable, Current_user.Current,
                                                    _view.Sender_Name, _view.Sender_Department, _view.Addres, _view.Room, _view.Phone_nom,
                                                    _view.Priority, _view.Type_problem, _view.Subject, _view.Description, _view.Rezult, null,
                                                    Convert.ToDateTime(_view.Date_start), Convert.ToDateTime(_view.Date_end), Convert.ToDateTime(_view.Date_control),
                                                    Current_user.Type_of_status[1]);
            ObservableCollection<Statement> s = new ObservableCollection<Statement>();
            s.Add(newStatement);
            Request r = new Request("update", Current_user.LPK, s, null);
            Client A = new Client();
            A.OutCommingCallAsync(r);
            //донастроить ответ - подтверждение
        }
       
        
    }
}
