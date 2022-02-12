

namespace Skola
{

    public class Osoba
    {
        public string _ime = String.Empty;
        public string _prezime = String.Empty;




    }

    public class Predavac : Osoba
    {
        public static List<Predavac> _predavaci = new();
        public static string _kurs;
       
    }

    public class Polaznik : Osoba
    {
        
        public static List<Polaznik> _polaznici = new();
        public List<string> _kursevi = new();

    }
}
