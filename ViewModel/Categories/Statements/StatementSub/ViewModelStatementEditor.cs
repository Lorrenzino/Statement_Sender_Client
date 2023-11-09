﻿using Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementEditor_Commands;
using Statement_Sender_Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub
{
    internal class ViewModelStatementEditor : ViewModelBase
    {
        private string _status;
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged(nameof(User_name));
            }
        }

        private string _user_name;
        public string User_name
        {
            get
            {
                return _user_name;
            }
            set
            {
                _user_name = value;
                OnPropertyChanged(nameof(User_name));
            }
        }

        private string _accountable;
        public string Accountable
        {
            get
            {
                return _accountable;
            }
            set
            {
                _accountable = value;
                OnPropertyChanged(nameof(Accountable));
            }
        }

        private string _worker;
        public string Worker
        {
            get
            {
                return _worker;
            }
            set
            {
                _worker = value;
                OnPropertyChanged(nameof(Worker));
            }
        }

        private string _sender;
        public string Sender
        {
            get
            {
                return _sender;
            }
            set
            {
                _sender = value;
                OnPropertyChanged(nameof(Sender));
            }
        }

        // изменяеміе поля (параметры отправителя)

        private string _adres;
        public string Adres
        {
            get
            {
                return _adres;
            }
            set
            {
                _adres = value;
                OnPropertyChanged(nameof(Adres));
            }
        }

        private string _department;
        public string Department 
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
                OnPropertyChanged(nameof(Department));
            }
        }

        private string _room;
        public string Room
        {
            get
            {
                return _room;
            }
            set
            {
                _room = value;
                OnPropertyChanged(nameof(Room));
            }
        }

        private string _phone_nom;
        public string Phone_nom
        {
            get
            {
                return _phone_nom;
            }
            set
            {
                _phone_nom = value;
                OnPropertyChanged(nameof(Phone_nom));
            }
        }
        // параметрі заявления

        private string _priority;
        public string Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }

        }
        private string _type_problem;
        public string Type_problem
        {
            get
            {
                return _type_problem;
            }
            set
            {
                _type_problem = value;
                OnPropertyChanged(nameof(Type_problem));
            }
        }

        private string _subject;
        public string Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        private string _rezult;
        public string Rezult
        {
            get
            {
                return _rezult;
            }
            set
            {
                _rezult = value;
                OnPropertyChanged(nameof(Rezult));
            }
        }

        // параметри дати

        private string _date_start;
        public string Date_start
        {
            get
            {
                return _date_start;
            }
            set
            {
                _date_start = value;
                OnPropertyChanged(nameof(Date_start));
            }
        }

        private string _date_end;
        public string Date_end
        {
            get
            {
                return _date_end;
            }
            set
            {
                _date_end = value;
                OnPropertyChanged(nameof(Date_end));
            }
        }

        private string _date_control;
        public string Date_control
        {
            get
            {
                return _date_control;
            }
            set
            {
                _date_control = value;
                OnPropertyChanged(nameof(Date_control));
            }
        }





        private bool _isChecked=false;
        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                if (_isChecked != value)
                {
                    _isChecked = value;
                    OnPropertyChanged(nameof(IsChecked));
                }
            }
        }


        public ICommand SendStatementE { get; }

        public ICommand CleanStatementE { get; }

        public ICommand CanselStatementE { get; }

        public ViewModelStatementEditor()
        {
            
            //кнопки
            SendStatementE = new SendStatementE_Command(this);
            CleanStatementE = new CleanStatementE_Command(this);
            CanselStatementE = new CanselStatementE_Command();

            _status = "Новий";
            _user_name = Current_user.Current.User_Name_Last + " " + Current_user.Current.User_Name_First + " " + Current_user.Current.User_Name_Father;
            _adres = Current_user.Current.Addres;
            _department = Current_user.Current.Department;
            _room = Current_user.Current.Room;
            _phone_nom = Current_user.Current.Phone;
        }
    }
}
