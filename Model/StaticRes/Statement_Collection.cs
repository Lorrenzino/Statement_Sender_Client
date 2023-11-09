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
        public static ObservableCollection<Statement> User_Statements;
        public static ObservableCollection<ViewModelStatement> User_StatementsVM;
        public static void UpSt()
        {
            User_StatementsVM = new ObservableCollection<ViewModelStatement>();
            User_StatementsVM.Add(new ViewModelStatement(new Model.Statement(
                11111,
                Current_user.Current,
                null,
                null,
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
                null,
                null,
                "Andrei 2",
                "SWAT",
                "adres2",
                "room2",
                "3489653298",
                "Висока",
                "Системний доступ",
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
                null,
                null,
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
                null,
                null,
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
