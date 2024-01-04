using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Model
{
    static class Current_user
    {
        public static bool isAutorise =false;
        public static User Current = new User();
        public static string[] LPK = { "user", "", "" };
        public static List<string> Type_of_status = new List<string> {  "Відкрито","Опрацьовується", "Призупинено","Повернуто", "Зроблено", "Скасовано" };
        public static List<string> Date_Interval = new List<string> { "Сьогодні", "Тиждень", "Місяць", "3 Місяці", "Рік","Увесь час" };
        public static List<string[]> Users_accountable = new List<string[]>();
        public static List<string> Type_of_department = new List<string> { };
        public static List<string> Type_of_problem = new List<string> { "Инвентаризация","Сеть","1С","Снабжение","Дениско"};
        public static List<string> Select_by = new List<string> {"Код","Назва","Дата створення","Дата виконання","Термін виконання","Статус","Виконавецт","Відповідальний","Пріорітет" };
    }
}
