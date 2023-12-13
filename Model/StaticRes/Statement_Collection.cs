using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statement_Sender_Client.Model;
using Statement_Sender_Client.ViewModel.Categories.Statements;

namespace Statement_Sender_Client.Model
{
    static class Statement_Collection
    {
        public static ObservableCollection<User> User_list = new ObservableCollection<User>();

        public static ObservableCollection<Statement> User_Statements = new ObservableCollection<Statement>();
        public static ObservableCollection<Statement> Department_Statements = new ObservableCollection<Statement>();
        public static ObservableCollection<Statement> ALL_Statements = new ObservableCollection<Statement>();
        //{"Type_R":"answer_select","LP":["user","user","","success"],"Data":[{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"Ivanov Ivan Ivanovich","Sender_Department":"erywyhew","Addres":"ewtrewy","Room":"NULL","Phone":"","Priority":"med","Type_problem":"????","Subject":"NULL","Description":"test_u_2","Rezult":"NULL","Log_convert":"NULL","Date_start":"1905-03-02T00:00:00","Date_end":"1899-12-31T00:00:00","Date_control":"1899-12-31T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"1","User_pers_nom":"1","User_Name_First":"admin","User_Name_Last":"System","User_Name_Father":"","Addres":"1","Room":"1","Phone":"1","Department":"System","User_Access_bill":"admin"},"Worker":{"User_ID":"1","User_pers_nom":"1","User_Name_First":"admin","User_Name_Last":"System","User_Name_Father":"","Addres":"1","Room":"1","Phone":"1","Department":"System","User_Access_bill":"admin"},"Sender_Name":"dhfh","Sender_Department":"ddfh","Addres":"dfh","Room":"dfh","Phone":"675","Priority":"low","Type_problem":"1?","Subject":"NULL","Description":"test_u_1","Rezult":"NULL","Log_convert":"NULL","Date_start":"1905-03-02T00:00:00","Date_end":"1899-12-31T00:00:00","Date_control":"1899-12-31T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"Ivanov Ivan Ivanovich","Sender_Department":"ert","Addres":"yerg","Room":"NULL","Phone":"5675","Priority":"low","Type_problem":"??????????????","Subject":"NULL","Description":"test_u_1","Rezult":"NULL","Log_convert":"NULL","Date_start":"1905-03-02T00:00:00","Date_end":"1899-12-31T00:00:00","Date_control":"1899-12-31T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"dhfh","Sender_Department":"ddfh","Addres":"dfh","Room":"dfh","Phone":"0","Priority":"low","Type_problem":"1?","Subject":"NULL","Description":"test_u_1","Rezult":"NULL","Log_convert":"NULL","Date_start":"1905-03-02T00:00:00","Date_end":"1899-12-31T00:00:00","Date_control":"1899-12-31T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"Ivanov Ivan Ivanovich","Sender_Department":"ert","Addres":"yerg","Room":"NULL","Phone":"5675","Priority":"low","Type_problem":"??????????????","Subject":"NULL","Description":"test_u_1","Rezult":"NULL","Log_convert":"NULL","Date_start":"1905-03-02T00:00:00","Date_end":"1899-12-31T00:00:00","Date_control":"1899-12-31T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"Ivanov Ivan Ivanovich","Sender_Department":"ert","Addres":"yerg","Room":"NULL","Phone":"5675","Priority":"low","Type_problem":"??????????????","Subject":"NULL","Description":"test_u_1","Rezult":"NULL","Log_convert":"NULL","Date_start":"1905-03-02T00:00:00","Date_end":"1899-12-31T00:00:00","Date_control":"1899-12-31T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"Ivanov Ivan Ivanovich","Sender_Department":"ert","Addres":"yerg","Room":"NULL","Phone":"5675","Priority":"low","Type_problem":"??????????????","Subject":"NULL","Description":"test_u_1","Rezult":"NULL","Log_convert":"NULL","Date_start":"1905-03-02T00:00:00","Date_end":"1899-12-31T00:00:00","Date_control":"1899-12-31T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"Ivanov Ivan Ivanovich","Sender_Department":"ert","Addres":"yerg","Room":"NULL","Phone":"5675","Priority":"low","Type_problem":"??????????????","Subject":"NULL","Description":"test_u_1","Rezult":"NULL","Log_convert":"NULL","Date_start":"1905-03-02T00:00:00","Date_end":"1899-12-31T00:00:00","Date_control":"1899-12-31T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"Ivanov Ivan Ivanovich","Sender_Department":"ert","Addres":"yerg","Room":"NULL","Phone":"5675","Priority":"low","Type_problem":"??????????????","Subject":"NULL","Description":"test_u_1","Rezult":"NULL","Log_convert":"NULL","Date_start":"1905-03-02T00:00:00","Date_end":"1899-12-31T00:00:00","Date_control":"1899-12-31T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"Ivanov Ivan Ivanovich","Sender_Department":"ert","Addres":"yerg","Room":"NULL","Phone":"5675","Priority":"low","Type_problem":"??????????????","Subject":"NULL","Description":"test_u_1","Rezult":"NULL","Log_convert":"NULL","Date_start":"1905-03-02T00:00:00","Date_end":"1899-12-31T00:00:00","Date_control":"1899-12-31T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"Ivanov Ivan Ivanovich","Sender_Department":"ddfh","Addres":"dfh","Room":"dfh","Phone":"675","Priority":"low","Type_problem":"1?","Subject":"NULL","Description":"test_u_1","Rezult":"NULL","Log_convert":"NULL","Date_start":"1905-03-16T00:00:00","Date_end":"1899-12-31T00:00:00","Date_control":"1899-12-31T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"1","User_pers_nom":"1","User_Name_First":"admin","User_Name_Last":"System","User_Name_Father":"","Addres":"1","Room":"1","Phone":"1","Department":"System","User_Access_bill":"admin"},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"","Sender_Department":"","Addres":"","Room":"","Phone":"","Priority":"low","Type_problem":"test","Subject":"","Description":"test_u_1","Rezult":"","Log_convert":"","Date_start":"1905-07-12T00:00:00","Date_end":"1905-06-27T00:00:00","Date_control":"1905-06-24T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"1","User_pers_nom":"1","User_Name_First":"admin","User_Name_Last":"System","User_Name_Father":"","Addres":"1","Room":"1","Phone":"1","Department":"System","User_Access_bill":"admin"},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"","Sender_Department":"","Addres":"","Room":"","Phone":"","Priority":"med","Type_problem":"test","Subject":"","Description":"test_u_2","Rezult":"","Log_convert":"","Date_start":"1905-07-12T00:00:00","Date_end":"1905-06-27T00:00:00","Date_control":"1905-06-24T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"1","User_pers_nom":"1","User_Name_First":"admin","User_Name_Last":"System","User_Name_Father":"","Addres":"1","Room":"1","Phone":"1","Department":"System","User_Access_bill":"admin"},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"","Sender_Department":"","Addres":"","Room":"","Phone":"","Priority":"high","Type_problem":"test","Subject":"","Description":"test_u_3","Rezult":"","Log_convert":"","Date_start":"1905-07-12T00:00:00","Date_end":"1905-06-27T00:00:00","Date_control":"1905-06-24T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"1","User_pers_nom":"1","User_Name_First":"admin","User_Name_Last":"System","User_Name_Father":"","Addres":"1","Room":"1","Phone":"1","Department":"System","User_Access_bill":"admin"},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"","Sender_Department":"","Addres":"","Room":"","Phone":"","Priority":"low","Type_problem":"test","Subject":"","Description":"test_u_4","Rezult":"","Log_convert":"","Date_start":"1905-07-12T00:00:00","Date_end":"1905-07-11T00:00:00","Date_control":"1905-06-24T00:00:00","Status":"призупинено"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"1","User_pers_nom":"1","User_Name_First":"admin","User_Name_Last":"System","User_Name_Father":"","Addres":"1","Room":"1","Phone":"1","Department":"System","User_Access_bill":"admin"},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"","Sender_Department":"","Addres":"","Room":"","Phone":"","Priority":"med","Type_problem":"test","Subject":"","Description":"test_u_5","Rezult":"","Log_convert":"","Date_start":"1905-07-12T00:00:00","Date_end":"1905-07-07T00:00:00","Date_control":"1905-06-24T00:00:00","Status":"відправлено"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"1","User_pers_nom":"1","User_Name_First":"admin","User_Name_Last":"System","User_Name_Father":"","Addres":"1","Room":"1","Phone":"1","Department":"System","User_Access_bill":"admin"},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"","Sender_Department":"","Addres":"","Room":"","Phone":"","Priority":"high","Type_problem":"test","Subject":"","Description":"test_u_6","Rezult":"","Log_convert":"","Date_start":"1905-07-12T00:00:00","Date_end":"1905-07-03T00:00:00","Date_control":"1905-06-24T00:00:00","Status":"зроблено"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"1","User_pers_nom":"1","User_Name_First":"admin","User_Name_Last":"System","User_Name_Father":"","Addres":"1","Room":"1","Phone":"1","Department":"System","User_Access_bill":"admin"},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"","Sender_Department":"","Addres":"","Room":"","Phone":"","Priority":"low","Type_problem":"test","Subject":"","Description":"test_u_7","Rezult":"","Log_convert":"","Date_start":"1905-07-12T00:00:00","Date_end":"1905-07-09T00:00:00","Date_control":"1905-06-24T00:00:00","Status":"опрацьовується"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"1","User_pers_nom":"1","User_Name_First":"admin","User_Name_Last":"System","User_Name_Father":"","Addres":"1","Room":"1","Phone":"1","Department":"System","User_Access_bill":"admin"},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"","Sender_Department":"","Addres":"","Room":"","Phone":"","Priority":"med","Type_problem":"test","Subject":"","Description":"test_u_8","Rezult":"","Log_convert":"","Date_start":"1905-07-12T00:00:00","Date_end":"1905-07-01T00:00:00","Date_control":"1905-06-24T00:00:00","Status":"sended"},{"ID_unic":0,"Sender":{"User_ID":"2","User_pers_nom":"2","User_Name_First":"user","User_Name_Last":"System","User_Name_Father":"","Addres":"2","Room":"2","Phone":"2","Department":"System","User_Access_bill":"user"},"Accountable":{"User_ID":"1","User_pers_nom":"1","User_Name_First":"admin","User_Name_Last":"System","User_Name_Father":"","Addres":"1","Room":"1","Phone":"1","Department":"System","User_Access_bill":"admin"},"Worker":{"User_ID":"","User_pers_nom":null,"User_Name_First":null,"User_Name_Last":null,"User_Name_Father":null,"Addres":null,"Room":null,"Phone":null,"Department":null,"User_Access_bill":null},"Sender_Name":"","Sender_Department":"","Addres":"","Room":"","Phone":"","Priority":"high","Type_problem":"test","Subject":"","Description":"test_u_9","Rezult":"","Log_convert":"","Date_start":"1905-07-12T00:00:00","Date_end":"1905-06-27T00:00:00","Date_control":"1905-06-24T00:00:00","Status":"опрацьовується"}]}

        public static ObservableCollection<ViewModelStatement> User_StatementsVM;

        public static void UpSt()
        {
            User_StatementsVM = new ObservableCollection<ViewModelStatement>();
            User_StatementsVM.Add(new ViewModelStatement(new Model.Statement(
                11111,
                Current_user.Current,
                null,
                Current_user.Current,
                "Andrei",
                "OMA",
                "adres1",
                "a101",
                "0965845865",
                "Низька",
                "Канцелярія",
                "problem_name1",
                "Заправити принтер",
                "цей комент",
                "",
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                "Відкрита"

       )));
            User_StatementsVM.Add(new ViewModelStatement(new Model.Statement(
                11112,
                Current_user.Current,
                Current_user.Current,
                Current_user.Current,
                "Andrei 2",
                "SWAT",
                "adres2",
                "room2",
                "3489653298",
                "Висока",
                "Сеть",
                "problem_name2",
                "Відновити дістанційний доступ",
                "",
                "",
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                "Завершена"

       )));
            User_StatementsVM.Add(new ViewModelStatement(new Model.Statement(
                11113,
                Current_user.Current,
                Current_user.Current,
                Current_user.Current,
               "Andrei 3",
               "SWAT",
               "adres3",
               "room3",
               "37545874587",
               "Висока",
               "Інвентарна",
               "problem_name3",
               "Зламався куллер",
               "pomogite pojosta",
               "",
               DateTime.Now,
               DateTime.Now,
               DateTime.Now,
               "Відкрита"

       )));
            User_StatementsVM.Add(new ViewModelStatement(new Model.Statement(
                11114,
                Current_user.Current,
                Current_user.Current,
                Current_user.Current,
               "Andrei4",
               "OMA",
               "adres4",
               "room4",
               "32653576778",
               "Висока",
               "Інвентарна",
               "problem_name4",
               "Потрібен новий вогнегасник",
               "",
               "",
               DateTime.Now,
               DateTime.Now,
               DateTime.Now,
               "Призупинена"

       )));
        }
    }
}
