using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NewRepo1
{
    class person
    {
        private string name; private string SecName;
        private System.DateTime DR;
        public person(string n, string s, DateTime b)
        {
            name = n; SecName = s;
            DR = b;
        }
        public person()
        {
            name = "Vova";
            SecName = "Kurlik"; DR = new DateTime(2000, 11, 1);
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string a)
        {
            name = a;
        }
        public string GetSecName()
        {
            return SecName;
        }
        public void SetSecName(string b)
        {
            SecName = b;
        }
        public DateTime GetDR()
        {
            return DR;
        }
        public void SetAge(DateTime c)
        {
            DR = c;
        }
        public string GetFullString()
        {
            return $"Имя: {name}, Фамилия: {SecName}, Дата рождения: {DR.ToString("d")}";
        }
        public string GetShortString()
        {
            return $"Имя: {name}, Фамилия: {SecName}";
        }
    }
}