using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task3.User;

namespace Epam.Task3.Employee
{
    class Emploee : Userr
    {
        public Emploee(string surname, string name, string patronymic, DateTime birthdate, int experience, string position)
            : base(surname, name, patronymic, birthdate)
        {
            this.Experience = experience;
            this.Position = position;
        }
        public int Experience { get; set; }
        public string Position { get; set; }
        public override void UserInfo()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}\nВозраст: {4} лет\nСтаж: {5} лет\nДолжность: {6}",
                Surname, Name, Patronymic, Birthdate, Age, Experience, Position);
        }

    }
}
