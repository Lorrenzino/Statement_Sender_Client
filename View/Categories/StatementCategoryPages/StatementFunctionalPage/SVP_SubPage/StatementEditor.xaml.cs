using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage
{
    /// <summary>
    /// Логика взаимодействия для StatementEditor.xaml
    /// </summary>
    public partial class StatementEditor : Page
    {
        public StatementEditor()
        {
            InitializeComponent();
            DataContext = new ViewModelStatementEditor();
        }
    }
}
