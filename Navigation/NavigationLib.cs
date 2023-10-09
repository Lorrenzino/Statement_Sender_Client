using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage;
using Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage;
using Statement_Sender_Client.ViewModel;

namespace Statement_Sender_Client.Navigation
{
    internal class NavigationLib : ViewModelBase
    {
        /*
        public RelayCommand AddComand => new RelayCommand(execute => { 
                                                                        //this shud be your command for binding
                                                                     }, 
                                                          canExecute => { 
                                                                        //this shud be your check on valid prev funk
                                                                        return true; 
                                                                        });
        */
        public Page StMP = new StatementMainPage();
        public Page StateEditPage = new StatementEditor();
        public Page ViewTabPage = new StatementViewerTabl();

        public Page _CurPage_StatementSub = new StatementViewerTabl();

        public Page CurPage_StatementSub 
        {
            get => _CurPage_StatementSub;
            set
            {
                _CurPage_StatementSub = value;
                OnPropertyChanged();
            }
        }

        //public RelayCommand Open_StateEditPage = new RelayCommand( execute =>{ CurPage_StatementSub = StateEditPage; });

    }
}
 