using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;



namespace Statement_Sender_Client.ViewModel.Categories.Statements
{
    internal class ViewModel_MainStatementPage: ViewModelBase
    {

        private ObservableCollection<ViewModelStatement> _statement_list_all ;

        public IEnumerable<ViewModelStatement> Statement_list_all => _statement_list_all;

        public ViewModel_MainStatementPage() 
        {
            _statement_list_all = new ObservableCollection<ViewModelStatement>();



            /*
            DataRotation.GetDataFromServer();
            Current_User.StatementCollection = DataRotation.GetData();
            ObservableCollection<ViewModelStatement> dat = new ObservableCollection<ViewModelStatement>();
            */

            /*
            foreach (var item in Current_User.StatementCollection)
            {
                _statement_list_all.Add(item);
            }
            */


            //MyState
            //Done 
            //Open 
            //Test 
            //Frost
            //Cansel
        }


        public ICommand MyState { get;}
        public ICommand Done { get; }
        public ICommand Open { get; }
        public ICommand Test { get; }
        public ICommand Frost { get; }
        public ICommand Cansel { get; }

        

        public ICommand OpenStatementsEditor { get; }

    }
}
