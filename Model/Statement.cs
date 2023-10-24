﻿using System;
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
        public int ID_state { get; }

        //parametr of user
        public User Sender { get; }
        public User Accountable { get; }
        public string Sender_Name { get; }
        public string Sender_Department { get; }
        public string Adres { get; }
        public string Room { get; }
        public string Phone { get; }

        //robochie param
        public string Type_problem { get; set; }
        public string Priority { get; set; }
        public string Abstract { get; set; } // результат роботи (замінити)
        public string Description { get; set; }
        // conect with user
        public string Comment { get; set; } // зворотній зв'язок (замінити)
        

        // no control atribut
        public DateTime Date_start {  get; set; }
        public DateTime Date_end { get; set; }
        public string Status { get; set; }

        public Statement(string sender_Name,
                        string sender_Department,
                        string adres,
                        string room,
                        string phone,
                        string type_problem,
                        string priority,
                        string abstract_,
                        string description,
                        string comment)
        {
            Sender = Current_user.Current;
            Sender_Name = sender_Name;
            Sender_Department = sender_Department;
            Adres = adres;
            Room = room;
            Phone = phone;
            Type_problem = type_problem;
            Priority = priority;
            Abstract = abstract_;
            Description = description;
            Comment = comment;
            Date_start = DateTime.Now;
            Status = "новий";
        }
        public Statement(int id_state,
                        string sender_Name,
                        string sender_Department,
                        string adres,
                        string room,
                        string phone,
                        string type_problem,
                        string priority,
                        string abstract_,
                        string description,
                        string comment)
        {
            ID_state = id_state;
            Sender = Current_user.Current;
            Sender_Name = sender_Name;
            Sender_Department = sender_Department;
            Adres = adres;
            Room = room;
            Phone = phone;
            Type_problem = type_problem;
            Priority = priority;
            Abstract = abstract_;
            Description = description;
            Comment = comment;
            Date_start = DateTime.Now;
            Status = "новий";
        }



        public Statement(int id_state,
                        string sender_Name,
                        string sender_Department,
                        string adres,
                        string room,
                        string phone,
                        string type_problem,
                        string priority,
                        string abstract_,
                        string description,
                        string comment,
                        DateTime dat,
                        string status) : this(id_state,
                                            sender_Name,
                                            sender_Department,
                                            adres,
                                            room,
                                            phone,
                                            type_problem,
                                            priority,
                                            abstract_,
                                            description,
                                            comment)
        {
            {
                this.Date_start = dat;
                this.Status = status;
            }
        }





    }
}
