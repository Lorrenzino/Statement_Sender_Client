using Statement_Sender_Client.View.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statement_Sender_Client.ViewModel;
using Statement_Sender_Client.Model;
using Statement_Sender_Client.Navigation.Categories.StatementCategory;
using Statement_Sender_Client.WorkWithData;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage
{
    class FormAll_command : CommandBase
    {
        private readonly NavigationLib _navigationLib;
        private readonly string _word;
        private readonly string _categor;

        ObservableCollection<ViewModelStatement> Statement_list= new ObservableCollection<ViewModelStatement>();

        public FormAll_command(NavigationLib lib, ObservableCollection<ViewModelStatement> _list, string word,string ctegor) 
        {
            _navigationLib = lib;
            _word = word;
            _categor = ctegor;
            if(word!=null) 
            foreach (ViewModelStatement st in _list)
            {
                if (st.Worker.User_ID == Current_user.Current.User_ID)
                    if (st.Status == word)
                        Statement_list.Add(st);
            }
        }

        public override void Execute(object parameter)
        {
            Statement_list.Clear();
            if (_word != "")
            { 
                switch (_categor)
                {
                    case "me":
                    foreach (ViewModelStatement st in Statement_Collection.User_StatementsVM)
                    {
                        if (Current_user.isAutorise)
                        {
                            if (st.Worker.User_ID == Current_user.Current.User_ID)
                                    if (st.Status == _word)
                                        Statement_list.Add(st);
                        }
                        else
                        {
                            if (st.Worker.User_pers_nom == Current_user.Current.User_pers_nom)
                                    if (st.Status == _word)
                                        Statement_list.Add(st);
                        }
                    }
                        break;
                    case "dep":
                    foreach (ViewModelStatement st in Statement_Collection.User_StatementsVM)
                    {
                        if (st.Accountable.Department == Current_user.Current.Department)
                                if (st.Status == _word)
                                    Statement_list.Add(st);
                    }
                        break;
                    case "my":
                    foreach (ViewModelStatement st in Statement_Collection.User_StatementsVM)
                    {
                        if (Current_user.isAutorise)
                        {
                            if (st.Sender.User_ID == Current_user.Current.User_ID)
                                    if (st.Status == _word)
                                        Statement_list.Add(st);
                        }
                        else
                        {
                            if (st.Sender.User_pers_nom == Current_user.Current.User_pers_nom)
                                    if (st.Status == _word)
                                        Statement_list.Add(st);
                        }
                    }
                        break;
                }
                
            }
            else
            {
                switch (_categor)
                {
                    case "me":
                        foreach (ViewModelStatement st in Statement_Collection.User_StatementsVM)
                        {
                            if (Current_user.isAutorise)
                            {
                                if (st.Worker.User_ID == Current_user.Current.User_ID)
                                    Statement_list.Add(st);
                            }
                            else
                            {
                                if (st.Worker.User_pers_nom == Current_user.Current.User_pers_nom)
                                    Statement_list.Add(st);
                            }
                        }
                        break;
                    case "dep":
                        foreach (ViewModelStatement st in Statement_Collection.User_StatementsVM)
                        {
                            if (st.Accountable.Department == Current_user.Current.Department)
                                Statement_list.Add(st);
                        }
                        break;
                    case "my":
                        foreach (ViewModelStatement st in Statement_Collection.User_StatementsVM)
                        {
                            if (Current_user.isAutorise)
                            {
                                if (st.Sender.User_ID == Current_user.Current.User_ID)
                                    Statement_list.Add(st);
                            }
                            else
                            {
                                if (st.Sender.User_pers_nom == Current_user.Current.User_pers_nom)
                                    Statement_list.Add(st);
                            }
                        }
                        break;
                }
            }
            _navigationLib.CurPage_Statements = new ViewModelListStatement(_navigationLib, Statement_list);
        }

    }
}
