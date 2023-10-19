using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Model
{
    class VirtualServer
    {
        public static ObservableCollection<Statement> Statements;
        public static ObservableCollection<Statement> GetData()
        {
            ObservableCollection<Statement> states = new ObservableCollection<Statement>();
            foreach (Statement statement in Statements)
            {
                states.Add(statement);
            }
            return states;
        }

        public static ObservableCollection<Statement> GetData(string department)
        {
            ObservableCollection<Statement> states = new ObservableCollection<Statement>();
            foreach (Statement statement in Statements)
            {
                if(statement.Sender_Department==department)
                    states.Add(statement);
            }
            return states;
        }
    }
}
