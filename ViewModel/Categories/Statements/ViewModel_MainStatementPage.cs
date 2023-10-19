using Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage;
using Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage;
using Statement_Sender_Client.Navigation;
using Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;



namespace Statement_Sender_Client.ViewModel.Categories.Statements
{
    internal class ViewModel_MainStatementPage: ViewModelBase
    {
        

        private ObservableCollection<ViewModelStatement> _statement_list_all ;

        public ObservableCollection<ViewModelStatement> Statement_list_all => _statement_list_all;


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
                "Відкрита"

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
                "Завершена"

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
               "Відкрита"

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
               "Призупинена"

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
            //Chang_DataContext_SubPage= new Chang_DataContext_SubPage(this, _statement_list_all);

            MyState = new MyState_Command(this, _statement_list_all);
            Done = new Done_Command(this, _statement_list_all);
            Open =new Open_Command(this, _statement_list_all);
            Test = new Test_Command(this, _statement_list_all);
            Frost = new Frost_Command(this, _statement_list_all);
            Canseled = new Canseled_Command(this, _statement_list_all);


            OpenStatementsEditor = new RelayCommand(OpenStatementsEditor_C);
        }
        // -------------------------------------------------------------------------------------------------------------------------'
        // Создаём навигациб
        // создаём страницы и добавляем команды перенаправляния для навигации
        public Page StateEditPage = new StatementEditor();
        public Page ViewTabPage = new StatementViewerTabl();

        public Page _CurPage_StatementSub = new StatementEditor();

        public Page CurPage_StatementSub
        {
            get => _CurPage_StatementSub;
            set
            {
                _CurPage_StatementSub = value;
                OnPropertyChanged();
            }
        }

        
        public RelayCommand Open_StateEditPage => new RelayCommand(execute => { CurPage_StatementSub = StateEditPage; });
        public RelayCommand Open_ViewTabPage => new RelayCommand(execute => { CurPage_StatementSub = ViewTabPage; });

        // -------------------------------------------------------------------------------------------------------------------------'
        // Обьявляем команды
        public ICommand MyState { get;}
        public ICommand Done { get; }
        public ICommand Open { get; }
        public ICommand Test { get; }
        public ICommand Frost { get; }
        public ICommand Canseled { get; }



        //test command to change datacontext
        public ICommand Chang_DataContext_SubPage { get; }



        public ICommand OpenStatementsEditor { get; }
        // -------------------------------------------------------------------------------------------------------------------------'
        // Реализация


        private void OpenStatementsEditor_C(object obj)
        {
            CurPage_StatementSub = StateEditPage;
        }

    }
}
