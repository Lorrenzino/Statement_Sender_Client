using Statement_Sender_Client.Navigation.Categories.StatementCategory;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage.StatementViewTabl_Commands
{
    class SortBy_Command : CommandBase
    {
        private readonly NavigationLib _navigationLib;
        private ViewModelListStatement _view;
        public SortBy_Command(NavigationLib lib, ViewModelListStatement Selected_item) 
        {
            _navigationLib = lib;
            _view = Selected_item;
        } 
        public override void Execute(object parameter)
        {
            ObservableCollection<ViewModelStatement> New_statement_list = new ObservableCollection<ViewModelStatement>(_view._statement_list);

            switch (_view.Select)
            {
                case "Код":
                    New_statement_list = new ObservableCollection<ViewModelStatement>(New_statement_list.OrderBy(i => i.Autor_ID));
                    break;
                case "Назва":
                    New_statement_list = new ObservableCollection<ViewModelStatement>(New_statement_list.OrderBy(i => i.Subject));
                    break;
                case "Дата створення":
                    New_statement_list = new ObservableCollection<ViewModelStatement>(New_statement_list.OrderBy(i => i.Date_start));
                    break;
                case "Дата виконання":
                    New_statement_list = new ObservableCollection<ViewModelStatement>(New_statement_list.OrderBy(i => i.Date_end));
                    break;
                case "Термін виконання":
                    New_statement_list = new ObservableCollection<ViewModelStatement>(New_statement_list.OrderBy(i => i.Date_control));
                    break;
                case "Статус":
                    New_statement_list = new ObservableCollection<ViewModelStatement>(New_statement_list.OrderBy(i => i.Status));
                    break;
                case "Виконавецт":
                    New_statement_list = new ObservableCollection<ViewModelStatement>(New_statement_list.OrderBy(i => i.Worker.User_Name_First));
                    break;
                case "Відповідальний":
                    New_statement_list = new ObservableCollection<ViewModelStatement>(New_statement_list.OrderBy(i => i.Accountable.User_Name_First));
                    break;
                case "Пріорітет":
                    New_statement_list = new ObservableCollection<ViewModelStatement>(New_statement_list.OrderBy(i => i.Priority));
                    break;
                
            }
            _view._statement_list = New_statement_list;

        }
    }
}
