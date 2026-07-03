using lec10.classes;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ[] employ = new Employ[8];

            employ[0] = new Employ("andria", "archvadze", new DateTime(1990, 5, 15), Country.georgia, Gender.male, Contacts.andria);
            employ[1] = new Employ("nika", "lursmanasvili", new DateTime(1988, 7, 18), Country.georgia, Gender.male, Contacts.nika);
            employ[2] = new Employ("lika", "tartarasvili", new DateTime(1990, 3, 30), Country.georgia, Gender.female, Contacts.vigac);
            employ[3] = new Employ("jhon", "doe", new DateTime(1990, 6, 5), Country.usa, Gender.male, Contacts.vigac);
            employ[4] = new Employ("lee", "hu", new DateTime(1990, 5, 9), Country.japan, Gender.male, Contacts.vigac);
            employ[5] = new Employ("james", "lebron", new DateTime(1990, 9, 7), Country.england, Gender.male, Contacts.vigac);
            employ[6] = new Employ("guks", "vigacaze", new DateTime(1990, 5, 5), Country.georgia, Gender.male, Contacts.vigac);
            employ[7] = new Employ("jordan", "michael", new DateTime(1990, 12, 22), Country.usa, Gender.male, Contacts.vigac);

            Employ.Printemploycont(employ, Country.georgia);
            Employ.Printemploycont(employ, Country.usa);
            Employ.Printemploycont(employ, Country.japan);
            Employ.Printemploycont(employ, Country.england);


        }
    }

    public enum Country
    {
        georgia,
        usa,
        japan,
        england,

    }
    public enum Gender
    {
        male,
        female,
    }
    public enum Contacts
    {
        andria = 555112233,
        nika = 555445566,
        vigac = 555778899,
    }
}

