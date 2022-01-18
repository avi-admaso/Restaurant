using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant.Models
{
    //9.	צרו מודל של מלצר עם שדות :ID , שם פרטי, שם משפחה, תאריך לידה ומספר שעות עבודה.
    public class Waiter
    {
        public Waiter(int id, string name, string lName, DateTime birthDate, int workHour)
        {
            Id = id;
            this.Name = name;
            this.lName = lName;
            this.birthDate = birthDate;
            this.WorkHour = workHour;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string lName { get; set; }
        public DateTime birthDate { get; set; }
        public int WorkHour { get; set; }
    }
}