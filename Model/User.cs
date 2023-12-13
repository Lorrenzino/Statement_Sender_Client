using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Model
{
    internal class User
    {
        public string User_ID;
        //public string User_IP;
        public string User_Name_First;
        public string User_Name_Last;
        public string User_Name_Father;
        public string Addres;
        public string Room;
        public string Phone;
        public string Department;
        public string User_Access_bill;
        public string Unic_User_log;



        public User(int a)
        {
            string IP = GetIPthisComputer();
            
        }

        //вынести в отдельный класс

        public string GetIPthisComputer()
        {
            return "0.0.0.0";
        }



        //заглушка
    



        public User(string user_ID,
                   string user_Name_First,
                   string user_Name_Last,
                   string user_Name_Father,
                   string adres,
                   string room,
                   string phone,
                   string department,
                   string user_access_bill,
                   string unic_user_log)
        {
            this.User_ID = user_ID;
            this.User_Name_First = user_Name_First;
            this.User_Name_Last = user_Name_Last;
            this.User_Name_Father = user_Name_Father;
            this.Addres = adres;
            this.Room = room;
            this.Phone = phone;
            this.Department = department;
            this.User_Access_bill = user_access_bill;
            this.Unic_User_log = unic_user_log;
        }




        public User(string id)
        {
            User_ID = id;
        }
        


        public User()
        {
            this.User_ID = "2";
            this.User_Name_First = "Ivan";
            this.User_Name_Last = "Ivanov";
            this.User_Name_Father = "Ivanovich";
            this.Addres = "0";
            this.Room = "0";
            this.Phone ="+000000000000";
            this.Department = "0";
            this.User_Access_bill = "common";
            this.Unic_User_log = "2";
        }
    }
}
