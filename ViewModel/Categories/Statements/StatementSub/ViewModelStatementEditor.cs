using Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementEditor_Commands;
using Statement_Sender_Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub
{
    internal class ViewModelStatementEditor : ViewModelBase
    {
        public List<string> Type_of_problem => Current_user.Type_of_problem;
        


        private string _Autor_ID;
        public string Autor_ID
        {
            get { return _Autor_ID; }
        }

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
                OnPropertyChanged(nameof(Status));
            }
        }

        private User _accountable;
        
        public User Accountable
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
        

        private User _worker;
        
        public User Worker
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
        

        private User _sender;
        
        public User Sender
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
        /*
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
        */

        private string _sender_department;
        public string Sender_Department
        {
            get
            {
                return _sender_department;
            }
            set
            {
                _sender_department = value;
                OnPropertyChanged(nameof(Sender_Department));
            }
        }


        private string _addres;
        public string Addres
        {
            get
            {
                return _addres;
            }
            set
            {
                _addres = value;
                OnPropertyChanged(nameof(Addres));
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

        private DateTime? _date_start = DateTime.Now;
        public DateTime? Date_start
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

        private DateTime? _date_end;
        public DateTime? Date_end
        {
            get
            {
                if (_date_end == DateTime.MinValue)
                    return null;
                return _date_end;
            }
            set
            {
                _date_end = value;
                OnPropertyChanged(nameof(Date_end));
            }
        }

        private DateTime? _date_control;
        public DateTime? Date_control
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

        // ----------------------------------------
        private string _sender_Name;
        public string Sender_Name
        {
            get
            {
                return _sender_Name;
            }
            set
            {
                _sender_Name = value;
                OnPropertyChanged(nameof(Sender_Name));
            }
        }


        private string _worker_Name;
        public string Worker_Name
        {
            get
            {
                return _worker_Name;
            }
            set
            {
                _worker_Name = value;
                OnPropertyChanged(nameof(Worker_Name));
            }
        }

        private string _accountable_Name;
        public string Accountable_Name
        {
            get
            {
                return _accountable_Name;
            }
            set
            {
                _accountable_Name = value;
                OnPropertyChanged(nameof(Accountable_Name));
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

        // -----------------------------------------------------------------------------
        // переменніе для ьлокировки полей для редактирование

        //Обічно доступно всё кроме Номера Дата Завершения Исполнителя и Отправителя + ОПИСАНИЕ ТОЛЬКО ДЛЯ ЧТЕНИЯ
        // когда заявление уже напис
        public string _Visability_Date_st = "False";
        public string Visability_Date_st
        {
            get
            {
                return _Visability_Date_st;
            }
        }

        public string _Visability_Date_end = "False";
        public string Visability_Date_end
        {
            get
            {
                return _Visability_Date_end;
            }
        }

        public string _Visability_Date_con = "False";
        public string Visability_Date_con
        {
            get
            {
                return _Visability_Date_con;
            }
        }
        public string _Visability_User_param = "False";
        public string Visability_User_param
        {
            get
            {
                return _Visability_User_param;
            }
        }

        public string _Visability_Box_for_message = "False";
        public string Visability_Box_for_message
        {
            get
            {
                return _Visability_Box_for_message;
            }
        }

        public string _Visability_Accountabl = "False";
        public string Visability_Accountabl
        {
            get
            {
                return _Visability_Accountabl;
            }
        }

        public string _Visability_Worker = "False";
        public string Visability_Worker
        {
            get
            {
                return _Visability_Worker;
            }
        }
        public string _Visability_Sender = "False";
        public string Visability_Sender
        {
            get
            {
                return _Visability_Sender;
            }
        }


        // -----------------------------------------------------------------------------
        // переменніе для отображения кнопок
        public string _SendStatementE_visability = "Collapsed";
        public string SendStatementE_visability
        {
            get
            {
                return _SendStatementE_visability;
            }
        }

        public string _UpdateStatementE_visability = "Collapsed";
        public string UpdateStatementE_visability
        {
            get
            {
                return _UpdateStatementE_visability;
            }
        }

        public string _TakeStatementE_visability = "Collapsed";
        public string TakeStatementE_visability
        {
            get
            {
                return _TakeStatementE_visability;
            }
        }
        public string _ReturnStatementE_visability = "Collapsed";
        public string ReturnStatementE_visability
        {
            get
            {
                return _ReturnStatementE_visability;
            }
        }
        public string _FinishStatementE_visability = "Collapsed";
        public string FinishStatementE_visability
        {
            get
            {
                return _FinishStatementE_visability;
            }
        }
        public string _AbortStatementE_visability = "Collapsed";
        public string AbortStatementE_visability
        {
            get
            {
                return _AbortStatementE_visability;
            }
        }

        public ICommand SendStatementE { get; }

        public ICommand ChangStatementE { get; }

        public ICommand TakeInWorkStatementE { get; }

        public ICommand ReturnStatementE { get; }

        public ICommand FinishStatementE { get; }

        public ICommand CanselStatementE { get; }

        public ViewModelStatementEditor()
        { 
        _Visability_Date_end = "False";
        _Visability_Date_con = "True";
        _Visability_User_param = "True";
        _Visability_Box_for_message = "True";
        _Visability_Accountabl = "False";
        _Visability_Worker = "False";
        _Visability_Sender = "False";

        //кнопки
        SendStatementE = new SendStatementE_Command(this);
        ChangStatementE = new ChangStatementE_Command(this);
        TakeInWorkStatementE = new TakeInWorkStatementE_Command(this);
        //ReturnStatementE= new ReturnStatementE_Command(this);
        FinishStatementE = new FinishStatementE_Command(this);
        CanselStatementE = new CanselStatementE_Command(this);

            _status = Current_user.Type_of_status[0];
            _sender_Name = Current_user.Current.User_Name_Last + " " + Current_user.Current.User_Name_First + " " + Current_user.Current.User_Name_Father;
            _addres = Current_user.Current.Addres;
            _sender_department = Current_user.Current.Department;
            _room = Current_user.Current.Room;
            _phone_nom = Current_user.Current.Phone;

            _SendStatementE_visability = "Visible";
            _UpdateStatementE_visability = "Collapsed";
            _TakeStatementE_visability = "Collapsed";
            _ReturnStatementE_visability = "Collapsed";
            _FinishStatementE_visability = "Collapsed";
            _AbortStatementE_visability= "Collapsed";

        }
        public ViewModelStatementEditor(ViewModelStatement view)
        {
            _SendStatementE_visability = "Hidden";
            //кнопки
            SendStatementE = new SendStatementE_Command(this);
            ChangStatementE = new ChangStatementE_Command(this);
            TakeInWorkStatementE = new TakeInWorkStatementE_Command(this);
            //ReturnStatementE= new ReturnStatementE_Command(this);
            FinishStatementE = new FinishStatementE_Command(this);
            CanselStatementE = new CanselStatementE_Command(this);

            //если пользователь == отправитель
            if (view.Sender.User_pers_nom == Current_user.Current.User_pers_nom)
            {
                //Відкрито
                // можна : поміняти або відмінити (внимательно изменять можно не всеполя)
                if ((view.Status == Current_user.Type_of_status[0]))
                {
                    _Visability_User_param = "True";
                    _Visability_Box_for_message = "True";

                    _SendStatementE_visability = "Collapsed";
                    _UpdateStatementE_visability = "Visible";
                    _AbortStatementE_visability = "Visible";
                }
                //Опрацьовується
                // можна : відмінити ,відмінити
                if ((view.Status == Current_user.Type_of_status[1]))
                {
                    _Visability_Box_for_message = "True";

                    _AbortStatementE_visability = "Visible";
                }
                //Призупинено
                // можна : повернути(щось не влаштовує) ,відмінити
                if ((view.Status == Current_user.Type_of_status[2]))
                {
                    _Visability_Box_for_message = "True";

                    _ReturnStatementE_visability = "Visible";
                    _AbortStatementE_visability = "Visible";
                }
                //Повернуто
                // можна повернути(щось не влаштовує), редагувати, відмінити
                if (view.Status == Current_user.Type_of_status[3])
                {
                    _Visability_Box_for_message = "True";

                    _ReturnStatementE_visability = "Visible";
                    _UpdateStatementE_visability = "Visible";
                    _AbortStatementE_visability = "Visible";
                }
                //Зроблено 
                // можно повернути(щось не влаштовує), завершини (та сама кнопка - підтвердження)
                if (view.Status == Current_user.Type_of_status[4])
                {
                    _Visability_Box_for_message = "True";

                    _ReturnStatementE_visability = "Visible";
                    _FinishStatementE_visability = "Visible";
                }
                //Скасовано
                // можно надіслати(знов)(щось не влаштовує), завершини (та сама кнопка - підтвердження)
                if (view.Status == Current_user.Type_of_status[5])
                {
                    _Visability_Box_for_message = "True";

                    _ReturnStatementE_visability = "Visible";
                    _FinishStatementE_visability = "Visible";
                }

                
            }

            //если пользователь == в составе отдела - получателя
            if ((view.Accountable.Department == Current_user.Current.Department)|| (view.Worker.Department == Current_user.Current.Department))
            {
                //Відкрито
                //Опрацьовується

                _TakeStatementE_visability = "Visible";
                _AbortStatementE_visability = "Visible";

                //Призупинено
                if (view.Status == Current_user.Type_of_status[2])
                {

                    _ReturnStatementE_visability = "Visible";
                    _FinishStatementE_visability = "Visible";
                    _AbortStatementE_visability = "Visible";
                }
                //Повернуто
                // можна повернути(щось не влаштовує), редагувати, відмінити
                if (view.Status == Current_user.Type_of_status[3])
                {
                    _TakeStatementE_visability = "Collapsed";
                    _AbortStatementE_visability = "Collapsed";
                }
                //Зроблено 
                // можно повернути(щось не влаштовує), завершини (та сама кнопка - підтвердження)
                if (view.Status == Current_user.Type_of_status[4])
                {
                    _TakeStatementE_visability = "Collapsed";
                    _AbortStatementE_visability = "Collapsed";
                }
                //Скасовано
                // можно надіслати(знов)(щось не влаштовує), завершини (та сама кнопка - підтвердження)
                if (view.Status == Current_user.Type_of_status[5])
                {
                    _TakeStatementE_visability = "Collapsed";
                    _AbortStatementE_visability = "Collapsed"; 
                }

                if (Current_user.Current.User_Access_bill == "admin")
                {
                    _Visability_Worker = "True";
                }
            }

            /*
            _UpdateStatementE_visability = "Collapsed";
            _TakeStatementE_visability = "Collapsed";
            _ReturnStatementE_visability = "Collapsed";
            _FinishStatementE_visability = "Collapsed";
            _AbortStatementE_visability = "Collapsed";
            */
            if (view.Status != null)
                _status = view.Status;

            if (view.Autor_ID != null)
                _Autor_ID=view.Autor_ID;
            if (view.Date_start != null)
                _date_start= Convert.ToDateTime( view.Date_start);
            if (view.Date_control != null)
                _date_control = Convert.ToDateTime(view.Date_control);
            if (view.Date_end != null)
                _date_end= Convert.ToDateTime(view.Date_end);
            //if (view != null)
              //  _sender_Name = Current_user.Current.User_Name_Last + " " + Current_user.Current.User_Name_First + " " + Current_user.Current.User_Name_Father;
            if (view.Addres != null)
                _addres = view.Addres;
            if (view.Sender_Department != null)
                _sender_department = view.Sender_Department;
            if (view.Room != null)
                _room = view.Room;
            if (view.Phone != null)
                _phone_nom = view.Phone;

            if (view != null)
                _priority = view.Priority;
            if (view != null) 
                _subject = view.Subject;
            if (view != null)
                _description= view.Description;
            if (view != null)
                _rezult = view.Rezult;
            if (view != null)
                _type_problem= view.Type_problem;
            if (view.Sender != null)
            {
                _sender = view.Sender;
                _sender_Name = view.Sender.User_Name_First;
            }
            if (view.Worker != null)
            {
                _worker = view.Worker;
                _worker_Name = view.Worker.User_Name_First;
            }
            if (view.Accountable != null)
            {
                _accountable = view.Accountable;
                _accountable_Name = view.Accountable.User_Name_First;
            }
            
        }
    }
}
