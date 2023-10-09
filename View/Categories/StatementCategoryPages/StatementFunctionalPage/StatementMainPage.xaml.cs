using Statement_Sender_Client.Navigation;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using System.Windows.Controls;

namespace Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage
{
    /// <summary>
    /// Логика взаимодействия для StatementMainPage.xaml
    /// </summary>
    public partial class StatementMainPage : Page
    {
        public StatementMainPage()
        {
            InitializeComponent();
            DataContext = new ViewModel_MainStatementPage();
        }
    }
}
