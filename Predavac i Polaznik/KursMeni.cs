using Skola;
internal class KursMeni
{
    public static void MeniKurs()
    {
        Console.WriteLine("===================");
        Console.WriteLine("1. Unos Kursa");
        Console.WriteLine("2. Prethodni Meni");
        Console.WriteLine("===================");

        string kurs = Console.ReadLine();
        switch (kurs)
        {
            case "1":
                Console.Clear();
                UnosKursa();
                break;
     
            case "2":
                return;

            default:
                Console.WriteLine("ERROR");
                break;
        }
    }
    public static void UnosKursa()
    {

        Console.Write("Unesite ime kursa: ");
        Polaznik._polaznici[0]._kursevi.Add( Console.ReadLine());
        /*Trebas da dodas da mozes index da uneses jer trenutno sve stavlja na
          prvi index mozes da iskoristis isti code za brisanje al malo drugacija
        */
    }

}