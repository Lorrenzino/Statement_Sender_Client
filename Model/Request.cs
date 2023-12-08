using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Sender_Client.Model
{
    internal class Request
    {
        
        /// <summary>
        /// У запроса может біть:
        /// 1. Тип - мі хотим знать что за и нформацию он нес'т и какой ответ хочет получить и хочеть ли
        /// 2. Данніе - он несёт какието данные которые хочет отправить на обработку 
        /// 2.1 ОН ОБЯЗАТЕЛЬНО - несёть с собой лог-проль или ключ сеантса jwt (которій я реализую)
        /// 2.2 Сопроводительная/уточнительная информация - данніе для изменения/внесения в БД или какие конкретно данные хочет получить
        /// </summary>



        // Все запросы строго типизированы
        // Список видов запросов и их права конкретезируются в БД

        // 1
        public string Type_R;

        // 2.1  на выбор
        public string[] LP; // логин пароль 
        public string Key;  // ключ сессии

        //2.2
        public ObservableCollection<Statement> Data; // данные для внесения или обновления в бд (операция указывается в типе)
        public List<string[]> Clarification; // уточнение формата {"Параметр", "Ограничение"} например: вывести все заявления отдела за последние 3 года адресованые на Городнера







        // Все запросы строго типизированы
        // Список видов запросов и их права конкретезируются в БД
        static private List<string> ReqwestTypeList = new List<string>();
        static public void RefreshReqwestType()
        {
            ReqwestTypeList.Add("select");
            ReqwestTypeList.Add("update");
            ReqwestTypeList.Add("insert");
            // зфпрос в бд на "горячее" обновление списка типов запросов 
            // выполняется при старте службы или по команде админа
        }
        public bool ValidTypeCheck()
        {
            return ReqwestTypeList.Contains(this.Type_R);
        }



        //Контсрукторы

        // C этим нужно просто смириться...
        // Главное нужно понять, что нас устравивают разные вариации запроса, НО! у него не может быть:
        // - пустое поле типа
        // - отсуствовать логин-пароль или ключ сесси (должно быть чтото одно)

        // Вот это не прпвильно
        /*
        public Request(string type_R, string[] lp, string key, List<Statement> data, List<string> clarification)
        {
            this.Type_R = type_R;
            this.LP = lp;
            this.Key = key;
            this.Data = data;
            this.Clarification = clarification;
        }
        */

        //  Запрос + логин
        public Request(string type_R, string[] lp)
        {
            this.Type_R = type_R;
            this.LP = lp;
        }

        public Request(string type_R, string key)
        {
            this.Type_R = type_R;
            this.Key = key;
        }

        // Запрос + логин + дата
        public Request(string type_R, string[] lp, ObservableCollection<Statement> data)
        {
            this.Type_R = type_R;
            this.LP = lp;
            this.Data = data;
        }

        public Request(string type_R, string key, ObservableCollection<Statement> data)
        {
            this.Type_R = type_R;
            this.Key = key;
            this.Data = data;
        }

        // Запрос + логин + уточнение
        public Request(string type_R, string[] lp, List<string[]> clarification)
        {
            this.Type_R = type_R;
            this.LP = lp;
            this.Clarification = clarification;
        }

        public Request(string type_R, string key, List<string[]> clarification)
        {
            this.Type_R = type_R;
            this.Key = key;
            this.Clarification = clarification;
        }

        // Запрос + логин + дата + уточнение
        public Request(string type_R, string[] lp, ObservableCollection<Statement> data, List<string[]> clarification)
        {
            this.Type_R = type_R;
            this.LP = lp;
            this.Data = data;
            this.Clarification = clarification;
        }

        public Request(string type_R, string key, ObservableCollection<Statement> data, List<string[]> clarification)
        {
            this.Type_R = type_R;
            this.Key = key;
            this.Data = data;
            this.Clarification = clarification;
        }
    }
}
