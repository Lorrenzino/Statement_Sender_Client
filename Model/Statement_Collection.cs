using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                "Andrei",
                "OMA",
                "adres1",
                "a101",
                "0965845865",
                "Канцелярія",
                "Низька",
                "problem_name1",
                "Заправити принтер",
                "цей комент",
                DateTime.Now,
                "Відкрита"

       )));
            User_StatementsVM.Add(new ViewModelStatement(new Model.Statement(
                11112,
                "Andrei 2",
                "SWAT",
                "adres2",
                "room2",
                "3489653298",
                "Системний доступ",
                "Висока",
                "problem_name2",
                "Відновити дістанційний доступ",
                "",
                DateTime.Now,
                "Завершена"

       )));
            User_StatementsVM.Add(new ViewModelStatement(new Model.Statement(
                11113,
               "Andrei 3",
               "SWAT",
               "adres3",
               "room3",
               "37545874587",
               "Інвентарна",
               "Висока",
               "problem_name3",
               "Зламався куллер",
               "pomogite pojosta",
               DateTime.Now,
               "Відкрита"

       )));
            User_StatementsVM.Add(new ViewModelStatement(new Model.Statement(
                11114,
               "Andrei4",
               "OMA",
               "adres4",
               "room4",
               "32653576778",
               "Інвентарна",
               "Висока",
               "problem_name4",
               "Потрібен новий вогнегасник",
               "",
               DateTime.Now,
               "Призупинена"

       )));
        }
    }
}
