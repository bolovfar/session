using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_BolovFarkhat_3ISP9_14
{
    internal class Person
    {
        private int IdPerson { get; set; }
        private string PersonName { get; set; }
        private string PersonSurname { get; set; }
        private string PersonPatronymic { get; set; }
        private DateTime PersonBirthday { get; set; }
        private char PersonGender { get; set; }
        private int PersonAge { get; set; }
        public virtual int Age  
        {
            get => PersonAge;
            set { if (value > 0 && value < 110) PersonAge = value; }
        }
        public Person(int id, string name, string surname, string patronymic, DateTime birthday, char gender, int age)    
                                                                                                                          
        {
            PersonName = name;
            PersonAge = age;
            PersonSurname = surname;
            PersonPatronymic = patronymic;
            PersonBirthday = birthday;
            PersonGender = gender;
            IdPerson = id;
        }
        public string GetPersonName    
        {
            get
            {
                return PersonName;
            }
        }
        public string SetPersonName    
        {
            set
            {
                PersonName = value;
            }
        }
    }
}
