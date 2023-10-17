using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub
{
    internal class ViewModelListStatement : ViewModelBase
    {

        public ObservableCollection<ViewModelStatement> _statement_list;

        public IEnumerable<ViewModelStatement> Statement_list => _statement_list;

        public ViewModelListStatement(ObservableCollection<ViewModelStatement> list)
        {
            _statement_list = new ObservableCollection<ViewModelStatement>();

            foreach (ViewModelStatement statement in list)
            {
                _statement_list.Add(statement);
            }
            OnPropertyChanged();


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
        public List<object> Selected;

        public void EventChangSelectedStat()
        {

        }
        public ICommand Chang { get; }
        public ICommand Delet { get; }
        public ICommand SetAs { get; }
        public ICommand ChangStatus { get; }
        public ICommand ChangPriorite { get; }


    }

        

    
}
