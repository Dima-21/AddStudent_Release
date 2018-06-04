using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Student
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
        public List<int> Marks { get; set; }

    }
}
