using _10;
using System;
using System.Collections.Generic;
using System.Text;

namespace lec10.classes
{
    internal class Employ
    {
        public string name;
        public string surename;
        public DateTime datetime;
        public Country country;
        public Gender gender;
        public Contacts contact;
        public Employ(string name, string surename, DateTime datetime, Country country, Gender gender, Contacts contact)
        {
            this.name = name;
            this.surename = surename;
            this.datetime = datetime;
            this.country = country;
            this.gender = gender;
            this.contact = contact;
        }
        public int getage()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - this.datetime.Year;
            if (this.datetime.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }


        public static void Printemploycont(Employ[] employs, Country country)
        {
            Console.WriteLine("tanamsromlebi qveynis mixedvit " + country);
            foreach (var item in employs)
            {
                if (item == null)
                    continue;

                if (item.country == country)
                {
                    Console.WriteLine(item.name + " " + item.surename);
                }
            }
        }
    }
}