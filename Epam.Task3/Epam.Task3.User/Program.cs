using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.User
{
    class Program
    {
        static void Main(string[] args)
        {
            Userr petya = new Userr("Козлов", "Петр", "Иванович", new DateTime(2000, 12, 01));
            petya.UserInfo();
        }
    }
}
