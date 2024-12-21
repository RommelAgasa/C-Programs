

namespace Privacy_Leak_Demo
{
    internal class Person
    {
        private string name;
        private Date dateOfBirth, dateOfDeath;

        public Person(string name, Date dateOfBirth)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.dateOfDeath = null;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Date DateOfBirth
        {
            get { return getBirth(dateOfBirth.Year, dateOfBirth.Month, dateOfBirth.Day); }
        }

        public Date getBirth(ushort y, byte m, byte d)
        {
            return new Date(y, m, d);
        }

        public ushort AgeAsOf(Date d)
        {
            return (ushort) (d.Year - dateOfBirth.Year);
        }

        public bool Alive()
        {
            return dateOfDeath == null;
        }

        public override string ToString()
        {
            return "Person: " + name + " " + dateOfBirth;
        }
    }
}
