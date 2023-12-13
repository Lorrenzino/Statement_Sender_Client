using Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage;
using Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage;
using Statement_Sender_Client.Model;
using Statement_Sender_Client.Navigation;
using Statement_Sender_Client.Navigation.Categories.StatementCategory;
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


       
        private ObservableCollection<ViewModelStatement> _statement_list_all => Statement_Collection.User_StatementsVM;
        public ObservableCollection<ViewModelStatement> statement_list_all
        {
            get 
            { 
                return _statement_list_all; 
            }
        }
        //public ObservableCollection<ViewModelStatement> Statement_list_all => Statement_Collection.User_StatementsVM;


        
        private void OnCurrentViewModeIChanged()
        {
            OnPropertyChanged(nameof(Current_Statements_ViewModel));
        }



        private readonly NavigationLib _navigationLib;
        public ViewModelBase Current_Statements_ViewModel => _navigationLib.CurPage_Statements;

        public ViewModel_MainStatementPage(NavigationLib navigationLib) 
        {
            _navigationLib = navigationLib;
            _navigationLib.CurrentViewModelChanged += OnCurrentViewModeIChanged;
            
            /*
            _navigationLib = navigationLib;

            
            
            _statement_list_all = new ObservableCollection<ViewModelStatement>();
            Statement_Collection.UpSt();
            foreach( ViewModelStatement vm in Statement_Collection.User_StatementsVM )
            {
                _statement_list_all.Add( vm );
            }           
           */

            MyState = new MyState_Command(_navigationLib, _statement_list_all);
            Done = new Done_Command(_navigationLib, _statement_list_all);
            Open =new Open_Command(_navigationLib, _statement_list_all);
            Test = new Test_Command(_navigationLib, _statement_list_all);
            Frost = new Frost_Command(_navigationLib, _statement_list_all);
            Canseled = new Canseled_Command(_navigationLib, _statement_list_all);
            //ChangPage_Command = new RelayCommand(CurPage);

            OpenStatementsEditor = new OpenStatementsEditor(_navigationLib);
        }
        // -------------------------------------------------------------------------------------------------------------------------'
        // Создаём навигациб
        // создаём страницы и добавляем команды перенаправляния для навигации
        
        

        
        
       

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
        // Поля для счётчиков
        // Скасовано Призупинено Відправлено Відкрита Зроблено
        public int _myState_count;
        public int MyState_count
        {
            get
            {
                int count = 0;
                foreach (ViewModelStatement st in statement_list_all)
                    if (st.Sender.User_ID ==Current_user.Current.User_ID)
                        count++;
                return _myState_count = count;
            }
            set
            {
                
            }
        }
        public int _myState_Done_count;
        public int MyState_Done_count
        {
           get
            {
                int count = 0;
                foreach (ViewModelStatement st in statement_list_all)
                    if (st.Sender.User_ID==Current_user.Current.User_ID)
                        if (st.Status == "Завершена")
                        count++;
                return _myState_Done_count = count;
            }
        }
        public int _myState_Open_count;
        public int MyState_Open_count
        {
            get
            {
                int count = 0;
                foreach (ViewModelStatement st in statement_list_all)
                    if (st.Sender.User_ID == Current_user.Current.User_ID)
                        if (st.Status == "Відкрита")
                            count++;
                return _myState_Open_count = count;
            }
        }
        public int _myState_Test_count;
        public int MyState_Test_count
        {
            get
            {
                int count = 0;
                foreach (ViewModelStatement st in statement_list_all)
                    if (st.Sender.User_ID == Current_user.Current.User_ID)
                        if (st.Status == "Відправлена")
                            count++;
                return _myState_Test_count = count;
            }
        }
        public int _myState_Frost_count;
        public int MyState_Frost_count
        {
            get
            {
                int count = 0;
                foreach (ViewModelStatement st in statement_list_all)
                    if (st.Sender.User_ID == Current_user.Current.User_ID)
                        if (st.Status == "Призупинена")
                            count++;
                return _myState_Frost_count = count;
            }
        }
        public int _myState_Canseled_count;
        public int MyState_Canseled_count
        {
            get
            {
                int count = 0;
                foreach (ViewModelStatement st in statement_list_all)
                    if (st.Sender.User_ID == Current_user.Current.User_ID)
                        if (st.Status == "Скасована")
                            count++;
                return _myState_Canseled_count = count;
            }
        }
       

    }
}
