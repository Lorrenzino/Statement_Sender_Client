using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statement_Sender_Client.Model;
using Statement_Sender_Client.ViewModel.Categories.Statements;

namespace Statement_Sender_Client.WorkWithData
{
    static class DataWorker
    {
        // Cheker
        public static bool IsDataActual(ObservableCollection<Statement> data)
        {
            if (data.Equals(Statement_Collection.User_Statements))
            {
                return true;
            }
            return false;
        }

        // Send
        public static void SendDataOnServer(ObservableCollection<Statement> data)
        {

        }

        public static void SendDataOnServer(Statement data)
        {
            //
            //Statement_Collection.User_Statements = WHAT_WE_GET
        }


        public static bool DataWorkerOnWork(Request Current_R)
        {
            bool feedback = false;

            switch (Current_R.Type_R)
            {
                case "answer_login":
                    if (Current_R.LP[3] == "success")
                    {
                        Current_user.Current = Current_R.Data[0].Sender;
                        Current_user.LPK[0] = Current_R.LP[0];
                        Current_user.LPK[1] = Current_R.LP[1];
                        Current_user.isAutorise = true;
                        feedback = true;
                    }
                    break;
                case "answer_select":
                    Statement_Collection.User_Statements.Clear();
                    Statement_Collection.User_StatementsVM.Clear();
                    foreach (Statement st in Current_R.Data)
                    {
                        Statement_Collection.User_Statements.Add(st);
                    }
                    Statement_Collection.User_Statements = new ObservableCollection<Statement>(Statement_Collection.User_Statements.OrderBy(i => i.ID_unic));
                    int i = 0;
                    //List < int >= new List<int>();
                    foreach (Statement st in Statement_Collection.User_Statements)
                    {
                        if (st.ID_unic != i)
                        {
                            i = st.ID_unic;
                            Statement_Collection.User_StatementsVM.Add(new ViewModel.Categories.Statements.ViewModelStatement(st));
                        }
                    }

                    
                        break;
                case "answer_update":
                    break;
                case "answer_insert":
                    break;
                case "answer_users_accountable":
                    foreach(User u in Current_R.users)
                    {
                        Current_user.Users_accountable.Add(u);
                    }
                    break;


            }

            return feedback;
        }

    }
}
