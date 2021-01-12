using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Functions
    {
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
    }
}
