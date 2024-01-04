using Statement_Sender_Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Markup;

namespace Statement_Sender_Client.WorkWithData
{
    static internal class LocalUser
    {
        

        private static string GetUserName()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }


        private static bool IsFallderExist()
        {
            string fallder = @"c:\Users\";
            return System.IO.Directory.Exists(fallder);
        }
        private static bool IsFileExist()
        {
            string file = @"HelpCUsers.txt";
            string username = GetUserName();
            string fallder = @"c:\Users\"+username+@"\"+file;
            return System.IO.File.Exists(fallder);
        }

        //private static string Create() { }
        public static void CreatLocalUser()
        {
            
            string username = GetUserName();
            string fallder = @"c:\Users\"+username;
            string file = fallder+@"\HelpCUsers.txt";
            if (!IsFallderExist())
            {
                Directory.CreateDirectory(fallder);
            }
            if(!IsFileExist())
                File.Create(file);


        }

        public static void AddLocalUser(User user)
        {
            List<User> users = new List<User>();
            User add = new User();
            string? line;

            string username = GetUserName();
            string fallder = @"c:\Users\" + username;
            string file = fallder + @"\HelpCUsers.txt";
            StreamWriter helpCUser = new StreamWriter(file);

            helpCUser.WriteLine(JsonConvert.SerializeObject(user));

            helpCUser.Close();


            //Request IncimingCall = JsonConvert.DeserializeObject<Request>(data);
            //string reqs = JsonConvert.SerializeObject(Answ);
        }

        public static List<User> GetLocalUser()
        {
            List<User> users = new List<User>();
            User add = new User();
            string? line;

            string username = GetUserName();
            string fallder = @"c:\Users\" + username;
            string file = fallder + @"\HelpCUsers.txt";
            StreamReader helpCUser = new StreamReader(file);

            while((line = helpCUser.ReadLine()) != null)
            {
                add = JsonConvert.DeserializeObject<User>(line);
                users.Add(add);
            }

            helpCUser.Close();

            return users;
        }
    }
}
