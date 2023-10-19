using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statement_Sender_Client.Model;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage
{
    internal class Canseled_Command : CommandBase
    {
        ViewModel_MainStatementPage VM_model;
        ObservableCollection<ViewModelStatement> Statement_list = new ObservableCollection<ViewModelStatement>();

        public Canseled_Command(ViewModel_MainStatementPage _model, ObservableCollection<ViewModelStatement> _list)
        {
            VM_model = _model;
            foreach (ViewModelStatement st in _list)
            {
                if (st.Autor_ID == Current_user.Current.User_ID)
                    if(st.Status=="Відмінено")
                    Statement_list.Add(st);
            }
        }

        public override void Execute(object parameter)
        {
            VM_model.ViewTabPage.DataContext = new ViewModelListStatement(Statement_list);

        }
    }
}
