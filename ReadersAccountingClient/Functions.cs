using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Functions
    {
        Regex numRegex;
        Regex charRegex;
        Regex CharRegex;
        public Functions()
        {
            numRegex = new Regex(@"[0-9]");
            charRegex = new Regex(@"[a-z]");
            CharRegex = new Regex(@"[A-Z]");
        }
        public Exception CheckDates(DateTime Issue, DateTime Return)
        {
            //провекра даты выдачи и возврата. после чего возвращаем исключение в случае чего
            if (Issue >= Return)
            {
                return new Exception("Дата возврата раньше даты выдачи");
            }
            else if ((Return - Issue) < TimeSpan.FromDays(7))
            {
                return new Exception("Время выдачи меньше недели");
            }
            return null;
        }
        public bool ValidatePassword(string password)
        {
            //проверка пароля
            if (password.Length < 8) return false;
            if (numRegex.Matches(password).Count < 1) return false;
            if (charRegex.Matches(password).Count < 1) return false;
            if (CharRegex.Matches(password).Count < 1) return false;
            return true;
        }
        public bool ValidateLogin(string login)
        {
            if (login.Length < 8) return false;
            return true;
        }
    }
}
