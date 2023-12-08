using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Statement_Sender_Client.Navigation.Categories.StatementCategory;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.ViewModel.MainWindows;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;

namespace Statement_Sender_Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        protected override void OnStartup(StartupEventArgs e)
        {
            Model.Statement_Collection.UpSt();
            NavigationLib lib = new NavigationLib();
            lib._CurPage_Main = new ViewModel_MainStatementPage(lib);
            lib._CurPage_Statements = new ViewModelStatementEditor();

            MainWindow = new MainWindow()
            {
                DataContext = new ViewModel_MainWindow(lib)
            };
            MainWindow.Show();


            base.OnStartup(e);
        }
        
    }
}
