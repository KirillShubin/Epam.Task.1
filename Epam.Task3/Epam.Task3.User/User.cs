using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.User
{
    public class Userr
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - Birthdate.Year;
                if (Birthdate > now.AddYears(-age))
                {
                    age--;
                }
                return age;
            }

        }
        public Userr(string Surname, string Name, string Patronymic, DateTime Birthdate)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Birthdate = Birthdate;
        }

        public virtual void UserInfo()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}\nВозраст: {4}", Surname, Name, Patronymic, Birthdate, Age);
        }
    }
}
