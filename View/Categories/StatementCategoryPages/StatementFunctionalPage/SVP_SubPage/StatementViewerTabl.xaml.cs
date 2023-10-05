using System.Collections.ObjectModel;
using System.Windows.Controls;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;

namespace Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage
{
    /// <summary>
    /// Логика взаимодействия для StatementViwerTabl.xaml
    /// </summary>
    public partial class StatementViwerTabl : Page
    {
        public StatementViwerTabl()
        {
            InitializeComponent();
            DataContext = new ViewModelListStatement();
        }
    }
}
