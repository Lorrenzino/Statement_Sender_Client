using Statement_Sender_Client.ViewModel;
using Statement_Sender_Client.Model;

namespace Statement_Sender_Client.ViewModel.Categories.Statements
{
    internal class ViewModelStatement : ViewModelBase
    {
        private readonly Statement _statement;

        public string Autor_ID => _statement.ID_unic.ToString(); // ChangMe  не правельні вівод
        public string Status => _statement.Status;
        public User Sender => _statement.Sender;
        public User Accountable => _statement.Accountable;
        public User Worker => _statement.Worker;


        //-------------------------------------------------------------
        public string Sender_Name;//=> _statement.Sender_Name;
        public string Sender_Department => _statement.Sender_Department;
        public string Addres => _statement.Addres;
        public string Room => _statement.Room;
        public string Phone => _statement.Phone;
        //-------------------------------------------------------------
        public string Priority => _statement.Priority;
        public string Type_problem => _statement.Type_problem;
        public string Subject => _statement.Subject;
        public string Description => _statement.Description;
        public string Rezult => _statement.Rezult;
        //-------------------------------------------------------------
        public string Date_start => _statement.Date_start.ToString();
        public string Date_end => _statement.Date_end.ToString();
        public string Date_control => _statement.Date_control.ToString();
        

        //-------------------------------------------------------------
        
        public string Accountable_Name ;//=> _statement.Accountable.User_Name_First;  // ChangMe краш если нулл
        public string Worker_Name ;//=> _statement.Worker.User_Name_First; // ChangMe краг если нул
        



        public ViewModelStatement(Statement _examp)
        {
            _statement = _examp;
            // Worker_name = _statement.Worker.User_Name_First;
            if (_statement != null)
            {
                if (_statement.Sender == null)
                    Sender_Name = string.Empty;
                if (_statement.Accountable == null)
                    Accountable_Name = string.Empty;
                if (_statement.Worker == null)
                    Worker_Name = string.Empty;
            }
        }
    }
}
