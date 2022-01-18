using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant.Models
{
    //4.	צרו מודל של טבח עם שדות :ID , שם מלא, גיל, אימייל ושכר.
    public class Chef
    {
        public int Id;
        public string fullName;
        public int age;
        public string mail;
        public int salary;

        public Chef(int id, string fullName, int age, string mail, int salary)
        {
            this.Id = id;
            this.fullName = fullName;
            this.age = age;
            this.mail = mail;
            this.salary = salary;
        }
    }
}