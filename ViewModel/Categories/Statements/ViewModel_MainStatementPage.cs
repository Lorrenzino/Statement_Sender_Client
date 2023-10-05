﻿using System;
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

            _statement_list_all.Add(new ViewModelStatement(new Model.Statement(
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
            _statement_list_all.Add(new ViewModelStatement(new Model.Statement(
                11112,
                "Andrei 2",
                "SWAT",
                "adres2",
                "room2",
                "3489653298",
                "Системний доступ",
                "Висока",
                "problem_name2",
                "Відновити дістанційний доступ",
                "",
                DateTime.Now,
                "Відправлено"

       )));
            _statement_list_all.Add(new ViewModelStatement(new Model.Statement(
                11113,
               "Andrei 3",
               "SWAT",
               "adres3",
               "room3",
               "37545874587",
               "Інвентарна",
               "Висока",
               "problem_name3",
               "Зламався куллер",
               "pomogite pojosta",
               DateTime.Now,
               "Відправлено"

       )));
            _statement_list_all.Add(new ViewModelStatement(new Model.Statement(
                11114,
               "Andrei4",
               "OMA",
               "adres4",
               "room4",
               "32653576778",
               "Інвентарна",
               "Висока",
               "problem_name4",
               "Потрібен новий вогнегасник",
               "",
               DateTime.Now,
               "Завершено"

       )));

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



        //test command to change datacontext
        public ICommand Chang_DataContext_SubPage { get; }



        public ICommand OpenStatementsEditor { get; }

    }
}
