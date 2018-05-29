using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Person
    {
        public string FIO
        {
            get
            {
                return $"{Surname} {Name[0]}.{Patronymic[0]}.";
            }
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public Person(string name, string surname, string patronymic, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Birthday = birthday;
        }
    }
}
