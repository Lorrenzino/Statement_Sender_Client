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
            if(data.Equals(Statement_Collection.User_Statements))
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


    }
}
