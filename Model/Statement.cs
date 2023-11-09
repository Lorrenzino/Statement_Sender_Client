using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Model
{
    internal class Statement
    {
        public int ID_unic { get; }

        //parametr of user
        public User Sender { get; }
        public User Accountable { get; }
        public User Worker { get; }
        public string Sender_Name { get; }
        public string Sender_Department { get; }
        public string Addres { get; }
        public string Room { get; }
        public string Phone { get; }

        //robochie param
        public string Priority { get; set; }
        public string Type_problem { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Rezult { get; set; } // результат a (замінити) abstrackt

        // conect with user
        public string Log_convert { get; set; } // зворотній зв'язок (замінити) Comment


        // no control atribut
        public DateTime Date_start { get; set; }
        public DateTime Date_end { get; set; }
        public DateTime Date_control { get; set; }
        public string Status { get; set; }

        public Statement(int id_unic,
                        User sender,
                        User accountable,
                        User worker,
                        string sender_name,
                        string sender_department,
                        string addres,
                        string room,
                        string phone,
                        string priority,
                        string type_problem,
                        string subject,
                        string description,
                        string rezult,
                        string log_conv,
                        DateTime ds,
                        DateTime de,
                        DateTime dc,
                        string status)
        {
            ID_unic = id_unic;
            Sender = sender;
            Accountable = accountable;
            Worker = worker;
            Sender_Name = sender_name;
            Sender_Department = sender_department;
            Addres = addres;
            Room = room;
            Phone = phone;
            Priority = priority;
            Type_problem = type_problem;
            Subject = subject;
            Rezult = rezult;
            Description = description;
            Log_convert = log_conv;
            Date_start = ds;
            Date_end = de;
            Date_control = dc;
            Status = status;

            if (sender_department == null)
            {
                Sender_Department = Sender.Department;
            }
            if (addres == null)
            {
                Addres = Sender.Addres;
            }
            if (room == null)
            {
                room = Sender.Room;
            }
            if (phone == null)
            {
                phone = Sender.Phone;
            }

            if (sender_name == null)
            {
                Sender_Name = Sender.User_Name_Last + " " + Sender.User_Name_First + " " + Sender.User_Name_Father;
            }
        }


        public Statement(
                       User sender,
                       string priority,
                       string type_problem,
                       string description,
                       DateTime ds,
                       string status)
        {
            Sender = sender;
            Sender_Name = Sender.User_Name_Last + " " + Sender.User_Name_First + " " + Sender.User_Name_Father;
            Sender_Department = Sender.Department;
            Addres = Sender.Addres;
            Room = Sender.Room;
            Phone = Sender.Phone;
            Priority = priority;
            Type_problem = type_problem;
            Description = description;
            Date_start = ds;
            Status = status;
        }





    }
}
