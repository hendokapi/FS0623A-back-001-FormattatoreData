// Chiede giorno, mese e anno ritorna la data formattata (implementare controlli) 30/1/2024

namespace Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("FORMATTORE DATE");
            Console.Write("Giorno: ");
            int readDay = int.Parse(Console.ReadLine());
            Console.Write("Mese: ");
            int readMonth = int.Parse(Console.ReadLine());
            Console.Write("Anno: ");
            int readYear = int.Parse(Console.ReadLine());
            Date myDate = new Date(readDay, readMonth, readYear);
            Console.WriteLine(myDate.GenerateFormattedDate());
            Console.WriteLine(myDate.GenerateFormattedDate("La data formattata è:"));
            Console.WriteLine(myDate.GenerateFormattedDate(15));
            Console.ReadLine();
        }
    }
    
    public class Date
    {
        // fields (campi)
        private int _day;   // controlli
        private int _month; // controlli

        public const int MinDay = 1;
        public const int MaxDay = 31;
        public const int MinMonth = 1;
        public const int MaxMonth = 12;


        // properties (proprietà)
        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                if (MinDay <= value && value <= MaxDay)
                {
                    _day = value;
                }
            }
        }

        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                if (MinMonth <= value && value <= MaxMonth)
                {
                    _month = value;
                }
            }
        }

        public int Year { get; set; }

        //CONSTRUCTORS
        //public Date()
        //{
        //    Day = 30;
        //    Month = 1;
        //    Year = 2024;
        //}

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        //METHOS
        public string GenerateFormattedDate()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public string GenerateFormattedDate(string promptText)
        {
            return $"{promptText} {Day}/{Month}/{Year}";
        }

        public string GenerateFormattedDate(int minutes)
        {
            return $"Ciao stiamo per finire! Mancano {minutes} minuti";
        }
    }
}
