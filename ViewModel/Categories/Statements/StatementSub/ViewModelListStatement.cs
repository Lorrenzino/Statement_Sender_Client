using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub
{
    internal class ViewModelListStatement : ViewModelBase
    {

        private ObservableCollection<ViewModelStatement> _statement_list;

        public IEnumerable<ViewModelStatement> Statement_list => _statement_list;

        public ViewModelListStatement(ObservableCollection<ViewModelStatement> list)
        {
            int v = 1;
            _statement_list = new ObservableCollection<ViewModelStatement>();

            foreach (ViewModelStatement statement in list)
            {
                v++;
                _statement_list.Add(statement);
            }
            OnPropertyChanged();
            
            for(;v<3;v++)
            _statement_list.Add(new ViewModelStatement(new Model.Statement(
                11111,
                "Andrei",
                "OMA",
                "adres1",
                "a101",
                "0965845865",
                "Канцелярія",
                "Низька",
                "problem_name1",
                "Заправити принтер",
                "цей комент",
                DateTime.Now,
                "Відправлено"

       )));


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
