using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub
{
    internal class ViewModelListStatement : ViewModelBase
    {

        private ObservableCollection<ViewModelStatement> _statement_list;

        public IEnumerable<ViewModelStatement> Statement_list => _statement_list;

        public ViewModelListStatement()
        {

            _statement_list = new ObservableCollection<ViewModelStatement>();

            foreach (var statement in Statement_list)
            {
                _statement_list.Add(statement);
            }



            //_statement_list = new ObservableCollection<ViewModelStatement>();
            //DataRotation.GetDataFromServer();
            //Current_User.StatementCollection = DataRotation.GetData();

            /*
            foreach (var item in Current_User.StatementCollection)
            {
                _statement_list.Add(item);
            }
            */
            /*
            foreach (ViewModelStatement el in Current_User.StatementCollection)
                if (el.Comment =="")
                    _statement_list.Add(el);
            */

        }

        
    }
}
