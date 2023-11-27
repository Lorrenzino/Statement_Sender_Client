using Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage;
using Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage;
using Statement_Sender_Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Statement_Sender_Client.Navigation.Categories.StatementCategory
{
    internal class NavigationLib
    {
        public event Action CurrentViewModelChanged;

        //private Page Statement = new StatementMainPage();
        //private Page ViewTabPage = new StatementViewerTabl();

        public ViewModelBase _CurPage_Main;

        public ViewModelBase CurPage_Main 
        {
            get => _CurPage_Main;
            set
            {
                _CurPage_Main = value;
                OnCurrentViewModelChanged();
            }
        }


        public ViewModelBase _CurPage_Statements;

        public ViewModelBase CurPage_Statements
        {
            get => _CurPage_Statements;
            set
            {
                _CurPage_Statements = value;
                OnCurrentViewModelChanged();
            }
        }









        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        /*
           КАК ВІЗІВАТЬ КОМАНДІ

        
        */

        /*

        private Page StateEditPage = new StatementEditor();
        private Page ViewTabPage = new StatementViewerTabl();

        private Page _CurPage_StatementSub;

        public Page CurPage_StatementSub
        {
            get => _CurPage_StatementSub;
            set
            {
                _CurPage_StatementSub = value;
                OnPropertyChanged();
            }
        }

        */


    }
}
