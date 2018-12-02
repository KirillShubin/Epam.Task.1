using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task3.User;

namespace Epam.Task3.Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Emploee Ivan = new Emploee("Иванов", "Иван", "Петрович", new DateTime(1980, 02, 01), 10, "директор");
            Ivan.UserInfo();
        }
    }
}
