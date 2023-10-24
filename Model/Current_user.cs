using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Model
{
    static class Current_user
    {
        public static User Current = new User();
        public static List<string> Type_of_status = new List<string> { "Відкрито", "закрито" };
        public static List<string> Type_of_department = new List<string> { };

    }
}
