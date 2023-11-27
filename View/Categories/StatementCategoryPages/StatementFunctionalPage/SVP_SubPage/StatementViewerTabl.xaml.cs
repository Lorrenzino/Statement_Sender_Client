using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Security.Cryptography.Xml;
using System.Windows.Controls;
using System.Windows.Input;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;

namespace Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage
{
    /// <summary>
    /// Логика взаимодействия для StatementViwerTabl.xaml
    /// </summary>
    public partial class StatementViewerTabl : Page
    {
        public StatementViewerTabl()
        {
            InitializeComponent();
            //this.DataContext = new ViewModelListStatement(new ObservableCollection<ViewModelStatement>());
        }

        
    }
}
