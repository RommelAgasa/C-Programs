

namespace Privacy_Leak_Demo
{
    internal class Date
    {
        private ushort year;
        private byte month, day;

        public Date(ushort year, byte month, byte day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public ushort Year
        {
           get { return year; }
           set { year = value; }
        }

        public byte Month
        {
            get { return month; }
            set { month = value; }
        }

        public byte Day
        {
            get { return day; }
            set { day = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}", day, month, year);
        }
    }
}
