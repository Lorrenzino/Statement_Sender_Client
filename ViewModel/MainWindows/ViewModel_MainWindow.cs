using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statement_Sender_Client.Navigation.Categories.StatementCategory;
using Statement_Sender_Client.ViewModel.Categories.Statements;

namespace Statement_Sender_Client.ViewModel.MainWindows
{
    internal class ViewModel_MainWindow : ViewModelBase
    {
        private readonly NavigationLib _navigationLib;
        public ViewModelBase Current_Main_ViewModel => _navigationLib.CurPage_Main;


        public ViewModel_MainWindow(NavigationLib navigationLib)
        {
            _navigationLib = navigationLib;

            _navigationLib.CurrentViewModelChanged += OnCurrentViewModeIChanged;

        } 

        private void OnCurrentViewModeIChanged()
        {
            OnPropertyChanged(nameof(Current_Main_ViewModel));
        }
    }
}
