using Statement_Sender_Client.ViewModel;
using Statement_Sender_Client.Model;

namespace Statement_Sender_Client.ViewModel.Categories.Statements
{
    internal class ViewModelStatement : ViewModelBase
    {
        private readonly Statement _statement;

        //-------------------------------------------------------------
        public string Sender_Name => _statement.Sender_Name;
        public string Adres => _statement.Adres;
        public string Sender_Department => _statement.Sender_Department;
        public string Room => _statement.Room;
        public string Phone => _statement.Phone;
        //-------------------------------------------------------------
        public string Type_problem => _statement.Type_problem;
        public string Priority => _statement.Priority;
        public string Abstract => _statement.Abstract;
        public string Description => _statement.Description;
        public string Comment => _statement.Comment;
        //-------------------------------------------------------------
        public string Date_statemant => _statement.Date_statemant.ToString();
        public string Status => _statement.Status;

        public ViewModelStatement(Statement _examp)
        {
            _statement = _examp;
        }
    }
}
