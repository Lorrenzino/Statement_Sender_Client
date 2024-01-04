using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statement_Sender_Client.Model;


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
                        /*
                        foreach (User us in Statement_Collection.User_list)
                        {
                            if (st.Sender.User_pers_nom != null)
                                if (st.Sender.User_pers_nom == us.User_pers_nom)
                                    st.Sender = us;
                            if (st.Accountable.User_pers_nom != null)
                                if (st.Accountable.User_pers_nom == us.User_pers_nom)
                                    st.Accountable = us;
                            if (st.Worker.User_pers_nom != null)
                                if (st.Worker.User_pers_nom == us.User_pers_nom)
                                    st.Worker = us;
                        }
                        */
                            
                        Statement_Collection.User_Statements.Add(st);
                        Statement_Collection.User_StatementsVM.Add(new ViewModel.Categories.Statements.ViewModelStatement(st));
                    }
                    break;
                case "answer_update":
                    break;
                case "answer_insert":
                    break;
                
            }

            return feedback;
        }

    }
}
