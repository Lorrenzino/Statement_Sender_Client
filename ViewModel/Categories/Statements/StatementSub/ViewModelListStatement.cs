﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Windows.Input;
using Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementEditor_Commands.ManageButton;
using Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementViewTabl_Commands.chek;
using Statement_Sender_Client.Model;
using Statement_Sender_Client.Navigation;

namespace Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub
{
    internal class ViewModelListStatement : ViewModelBase
    {

        private ObservableCollection<ViewModelStatement> _statement_list;

        public ObservableCollection<ViewModelStatement> Statement_list => _statement_list;

        
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

            //EventChangSelectedStat = new EventChangSelectedStat_Command(this);

            //Delet = new DeleteStatementMB_Command(IsSelectedRow, this);


            //SortBy("Phone");
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
        public RelayCommand Delet => new RelayCommand(execute =>
        {
                for(int i=0; (i<= Statement_list.Count());i++)
                {
                try
                {

                
                    if (Statement_list[i] == IsSelectedRow)
                    {
                        Statement_list.Remove(Statement_list[i]);
                        Statement_Collection.User_StatementsVM.Remove(Statement_list[i]);
                        OnPropertyChanged();
                    }
                }
                catch (Exception ex) { }
                }
            
        });
        public RelayCommand SetAs => new RelayCommand(execute =>
        {
            SortBy("Sender_Name");
        });
        public RelayCommand ChangStatus => new RelayCommand(execute =>
        {
            SortBy("Priority");
        });
        public ICommand ChangPriorite { get; }


    }

        

    
}
