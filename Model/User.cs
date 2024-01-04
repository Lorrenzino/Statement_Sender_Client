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
        public string User_pers_nom;
        public string User_Name_First;
        public string User_Name_Last;
        public string User_Name_Father;
        public string Addres;
        public string Room;
        public string Phone;
        public string Department;
        public string User_Access_bill;
        //public string Unic_User_log;



        //заглушка
        public User(string user_ID,
                    string user_pers_nom,
                    string user_Name_First,
                    string user_Name_Last,
                    string user_Name_Father,
                    string adres,
                    string room,
                    string phone,
                    string department,
                    string user_access_bill
                    )
        {
            this.User_ID = user_ID;
            this.User_pers_nom = user_pers_nom;
            this.User_Name_First = user_Name_First;
            this.User_Name_Last = user_Name_Last;
            this.User_Name_Father = user_Name_Father;
            this.Addres = adres;
            this.Room = room;
            this.Phone = phone;
            this.Department = department;
            this.User_Access_bill = user_access_bill;
        }
       

        public User(string id)
        {
            User_ID = id;
        }



        public User()
        {
            this.User_ID = "6";
            this.User_pers_nom = "4";
            this.User_Name_First = "noauthorization";
            this.User_Name_Last = "System";
            this.User_Name_Father = "";
            this.Addres = "not";
            this.Room = "not";
            this.Phone ="0";
            this.Department = "not";
            this.User_Access_bill = "noauthorization";
            
        }
    }
}
