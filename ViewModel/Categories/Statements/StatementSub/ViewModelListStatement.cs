﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Windows.Input;
using Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementEditor_Commands.ManageButton;
using Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementViewTabl_Commands;

using Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementViewTabl_Commands.ClickOnCommand;
using Statement_Sender_Client.Model;
using Statement_Sender_Client.Navigation;
using Statement_Sender_Client.Navigation.Categories.StatementCategory;

namespace Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub
{
    internal class ViewModelListStatement : ViewModelBase
    {

        private readonly NavigationLib _navigationLib;
        public List<string> Date_Interval => Current_user.Date_Interval;

        public string _Select = Current_user.Date_Interval[3];
        public string Select

        {
            get
            {
                return _Select;
            }
            set
            {
                _Select = value;
                OnPropertyChanged(nameof(_Select));
            }
        }


        
        public ObservableCollection<ViewModelStatement>_statement_list = Statement_Collection.User_StatementsVM;
        public ObservableCollection<ViewModelStatement> statement_list
        {
            get
            {
                return _statement_list;
            }
        }


        public ViewModelStatement _Selected_item;
        public ViewModelStatement Selected_item
        {
            get
            {
                return _Selected_item;
            }
            set
            {
                _Selected_item = value;
                OnPropertyChanged(nameof(Selected_item));
            }
        }



        public ViewModelListStatement(NavigationLib navigationLib, ObservableCollection<ViewModelStatement> list)
        {
            _navigationLib = navigationLib;
            _statement_list = list;
            SetAs = new SortBy_Command(_navigationLib, this);
            RowDoubleCkick_Command = new MouseDoubleClick(_navigationLib, this);
            RefreshData_Command = new RefreshDataVT_Command(this);
        }

        public void SortBy(string parametr)
        {
            /*
            switch(parametr)
            {
                case "Sender_Name":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Sender_Name));
                    break;
                case "Adres":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Adres));
                    break;
                case "Sender_Department":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Sender_Department));
                    break;
                case "Room":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Room));
                    break;
                case "Phone":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Phone));
                    break;
                case "Type_problem":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Type_problem));
                    break;
                case "Priority":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Priority));
                    break;
                case "Abstract":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Abstract));
                    break;
                case "Description":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Description));
                    break;
                case "Comment":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Comment));
                    break;
                case "Date_statemant":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Date_statemant));
                    break;
                case "Status":
                    _statement_list = new ObservableCollection<ViewModelStatement>(_statement_list.OrderBy(i => i.Status));
                    break;
            }
            OnPropertyChanged();
            */
        }
        public List<object> Selected_objct;


        public ViewModelStatement IsSelectedRow =new ViewModelStatement(null);
        public ViewModelStatement SelectedRow
        {
            get { 
                return IsSelectedRow; 
            }
            set { 
                IsSelectedRow = value;
                OnPropertyChanged();
            }
        }
        public ICommand EventChangSelectedStat
        {
            get;
        }
        public ICommand Chang { get; }
        
        public ICommand SetAs { get; }

        public ICommand ChangPriorite { get; }

        public ICommand RowDoubleCkick_Command { get; }

        public ICommand RefreshData_Command { get; }

    }

        

    
}
