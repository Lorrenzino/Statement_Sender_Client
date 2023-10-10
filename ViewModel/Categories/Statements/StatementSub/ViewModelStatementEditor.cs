using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub
{
    internal class ViewModelStatementEditor : ViewModelBase
    {
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

        private string _specification;
        public string Specification
        {
            get
            {
                return _specification;
            }
            set
            {
                _specification = value;
                OnPropertyChanged(nameof(Specification));
            }
        }


        private string _short_description;
        public string Short_description
        {
            get
            {
                return _short_description;
            }
            set
            {
                _short_description = value;
                OnPropertyChanged(nameof(Short_description));
            }
        }

        private string _descriptionL;
        public string DescriptionL
        {
            get
            {
                return _descriptionL;
            }
            set
            {
                _descriptionL = value;
                OnPropertyChanged(nameof(DescriptionL));
            }
        }


        private string _about;
        public string About
        {
            get
            {
                return _about;
            }
            set
            {
                _about = value;
                OnPropertyChanged(nameof(About));
            }
        }



        public ICommand SendStatementCommand { get; }

        public ICommand CleanStatementCommand { get; }

        public ViewModelStatementEditor()
        {

        }
    }
}
